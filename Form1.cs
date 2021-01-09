﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace StoneShardItemEnchantEditor
{
    public partial class Form1 : Form
    {
        string fileData;
        JObject rss;
        List<Enchant> ens;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListOfEnchants();
            DirectoryInfo ss = new DirectoryInfo("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\StoneShard\\characters\\");

            DirectoryInfo[] path = ss.GetDirectories();
            foreach (DirectoryInfo file in path)
            {
                CharacterNames.Items.Add(file.Name);
            }
        }

        private void LoadCharacter_Click(object sender, EventArgs e)
        {
            ItemListBox.Items.Clear();
            string path = "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\StoneShard\\characters\\" + CharacterNames.SelectedItem + "\\save_1\\character.sav";
            //check for save file file
            if (!File.Exists(path))
            {
                MessageBox.Show("No Save File Exists for this character.");
                return;
            }
            StreamReader sr = new StreamReader(path);
            
            string jasontext = sr.ReadLine();
            fileData = jasontext;
            //dynamic array = JsonConvert.DeserializeObject(jasontext);
            rss = JObject.Parse(jasontext);
            
            var inventory = (JArray)rss["inventory"];
            int i = 0;
            foreach (var stone in inventory)
            {
                //Console.WriteLine(stone[0].ToString());
                if(rss["inventory"][i][1]["key"] != null)
                    ItemListBox.Items.Add(i + " " + stone[0].ToString());
                i++;
            }

        }

        private void LoadItem_Click(object sender, EventArgs e)
        {

            refreshEnchant();

            //var inventory = (JObject)rss["inventory"][ItemListBox.SelectedIndex][1]["key"];
            //foreach (var stone in inventory)
            //{
            //    Console.WriteLine(stone.Key);

            //}

        }
        private void refreshEnchant()
        {
            Enchantonitem.Rows.Clear();
            int id = int.Parse( ItemListBox.SelectedItem.ToString().Split(' ')[0].ToString());
            if (rss["inventory"][id][1]["key"] != null)
            {

                var inventory = (JObject)rss["inventory"][id][1];
                foreach (var stone in inventory)
                {

                   Console.WriteLine(stone);

                }

                if (rss["inventory"][id][1]["key"].ToString().Trim() != "")
                {
                    string enchant;
                    string name;
                    int ammount = 0;
                    
                    string overall = "";
                    JToken texst = rss["inventory"][id][1]["key"];
                    enchant = texst.ToString();
                    if (ens.FirstOrDefault(x => x.devname == enchant) != null)
                    {
                        name = ens.Where(x=>x.devname == enchant).Select(x=>x.IGn).Single().ToString();
                    }
                    else
                    {
                        name = "N/A";
                    }
                    if (rss["inventory"][id][1]["Char0"] != null)
                    {

                        ammount = int.Parse(rss["inventory"][id][1]["Char0"].ToString().Split(' ')[1].ToString().Replace("%", "").Replace("+", "").ToString());
                    }

                    if (rss["inventory"][id][1][enchant] != null)
                    {
                        overall = rss["inventory"][id][1][enchant].ToString();
                    }


                    Enchantonitem.Rows.Add(id,enchant, name, ammount, overall);
                    //change list of possible enchants
                    changeEnchantList(rss["inventory"][id][1]["Metatype"].ToString());
                }
                else
                {
                    MessageBox.Show("No Enchant Found");
                }
            }
        }



        private void SaveFile_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\StoneShard\\characters\\" + CharacterNames.SelectedItem  + "\\save_1\\character.sav";
            try
            {
                File.WriteAllText(path, Newtonsoft.Json.JsonConvert.SerializeObject(rss));
                MessageBox.Show("File Saved");
            }
            catch
            {
                MessageBox.Show("File Could not be saved over try again later.");
            }
        }

        private void swap()
        {
            string devnamed;
            string ConvientName;
            float amount = 0;
            string overall = "";
            string percent = "";
            JObject test;
            string type;
            int id = 0;

            if (Enchantonitem.SelectedRows.Count > 0 && EnchantList.SelectedItems.Count > 0)
            {
                DataGridViewRow dr = Enchantonitem.SelectedRows[0];
                Enchant eee = ens.Where(x => x.IGn == EnchantList.SelectedItem.ToString()).Single();
                id = int.Parse(dr.Cells[0].Value.ToString());
                type = eee.type;
                //type = ens.Select(x => x.type).FirstOrDefault(x => x.name == EnchantList.SelectedItem.ToString()).ToString();
                //check to see if enchants are capaitable
                if (rss["inventory"][id][1]["Metatype"].ToString() == type && Enchantonitem.SelectedRows[0].Cells[0].ToString() != "")
                {
                    //=======================================================================================================
                    // remove enchant 
                    //=======================================================================================================
                    devnamed = Enchantonitem.SelectedRows[0].Cells[1].Value.ToString();
                    ConvientName = Enchantonitem.SelectedRows[0].Cells[2].Value.ToString();
                    amount = float.Parse(Enchantonitem.SelectedRows[0].Cells[3].Value.ToString());
                    overall = Enchantonitem.SelectedRows[0].Cells[4].Value.ToString();

                    rss["inventory"][id][1]["key"] = "";
                    if (float.Parse(overall) != amount)
                    {
                        rss["inventory"][id][1][devnamed] = float.Parse(overall) - amount;
                    }
                    else
                    {
                        JObject test1 = (JObject)rss["inventory"][id][1];

                        test1.Property(devnamed).Remove();
                        //rss["inventory"][ItemListBox.SelectedIndex][1][enchant].Remove();

                    }

                    test = (JObject)rss["inventory"][id][1];

                    test.Property("Char0").Remove();
                    //=======================================================================================================
                    //add enchant
                    //=======================================================================================================
                    //get info from known enchant list
                    devnamed = eee.devname;
                    amount = eee.ammount;
                    percent = eee.percentage;

                    rss["inventory"][id][1]["key"] = devnamed;
                    //get item properties
                    test = (JObject)rss["inventory"][id][1];
                    //if enchant propertie exists on item already
                    if (rss["inventory"][id][1][devnamed] != null)
                    {
                        rss["inventory"][id][1][devnamed] = float.Parse(rss["inventory"][id][1][devnamed].ToString()) + amount;
                    }
                    else
                    {
                        test.Property("key").AddAfterSelf(new JProperty(devnamed, amount));
                    }
                    //if possitive
                    if (amount > 0)
                    {
                        test.Property("key").AddAfterSelf(new JProperty("Char0", devnamed + " +" + amount + percent));
                    }
                    else
                    {
                        test.Property("key").AddAfterSelf(new JProperty("Char0", devnamed + " " + amount + percent));
                    }
                    //=======================================================================================================

                    refreshEnchant();

                }
                else
                {
                    MessageBox.Show("Item Cannot have that type of enchant please choose another");
                }
            }
            else
            {
                MessageBox.Show("Please Select Enchant Row.");
            }
            
            
        }

        private void ListOfEnchants()
        {
            ens = new List<Enchant>();
            ens.Add(new Enchant() {devname = "EVS",IGn = "Dodge Chance", ammount = 3,type = "Armor" , percentage = "%" });
            ens.Add(new Enchant() { devname = "CTA", IGn = "Counter Chance", ammount = 5 ,type = "Weapon", percentage = "%" });
            ens.Add(new Enchant() { devname = "FMB", IGn = "Fumble Chance", ammount = -5, type = "Weapon", percentage = "%" });
            ens.Add(new Enchant() { devname = "CRT", IGn = "Crit Chance", ammount = 5, type = "Weapon", percentage = "%" });
            ens.Add(new Enchant() { devname = "PRR", IGn = "Block Chance", ammount = 5, type = "Weapon", percentage = "%" });
            ens.Add(new Enchant() { devname = "Hit_Chance", IGn = "Accuracy", ammount = 5, type = "Weapon", percentage = "%" });
        }

        private void changeEnchantList(string typez)
        {
            EnchantList.Items.Clear();
            EnchantList.Items.AddRange(ens.Where(x=>x.type == typez).Select(x => x.IGn).ToArray());
        }

        private void SwapEnchant_Click(object sender, EventArgs e)
        {
            swap();
        }
    }
    class Enchant
    {
        public string devname; //name originaly given by devs
        public string IGn; //in game name
        public float ammount; 
        public string type;
        public string percentage; // % sign if needed at the end
    }
}
