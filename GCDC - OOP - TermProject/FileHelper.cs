using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace GCDC___OOP___TermProject
{
    public static class FileHelper
    {
        /*NAME: FileHelper
        * DESCRIPTION: Static class that handles reading and writing files
        */

        //Name: GetUsers
        //Sent: -
        //Return: List<Users>
        //Desc: Returns a list of Users that is read from a text file. Catches exception if problem reading file
        public static List<Users> GetUsers()
        {
            List<Users> users = new List<Users>();
            try
            {
                StreamReader usersFile = new StreamReader(@"..\..\bin\Files\Users.txt");

                while (usersFile.Peek() != -1)
                {
                    Users user;
                    string fileLine = usersFile.ReadLine();
                    string[] userInfo = fileLine.Split(',');
                    if (userInfo[3] == "customer")
                        user = new Customer(userInfo[0], userInfo[1], userInfo[2], userInfo[3]);
                    else
                        user = new Admin(userInfo[0], userInfo[1], userInfo[2], userInfo[3]);
                    users.Add(user);
                }

                usersFile.Close();

                return users;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File Error");
                return null;
            }
        }

        //Name: SetUsers
        //Sent: List<Users>
        //Return: -
        //Desc: Overwrites the users file. Catches exception if problem reading file
        public static void SetUsers(List<Users> newUsers)
        {
            try
            {
                StreamWriter usersFile = new StreamWriter(@"..\..\bin\Files\Users.txt");

                foreach (Users user in newUsers)
                {
                    usersFile.WriteLine(user.UserID + "," + user.Password + "," + user.Name + "," + user.Access);
                }

                usersFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File Error");
            }
        }

        //Name: SetHamsters
        //Sent: List<Users>
        //Return: -
        //Desc: Overwrites the products file and adding a new hamster. Catches exception if problem reading file
        public static void SetProducts(List<Hamsters> newHamsters, List<Necessities> newNecessities)
        {
            try
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.IndentChars = ("    ");

                XmlWriter xmlOut = XmlWriter.Create(@"..\..\bin\Files\Products.xml", settings);

                xmlOut.WriteStartDocument();
                xmlOut.WriteStartElement("Products");
                xmlOut.WriteStartElement("Hamsters");

                foreach (Hamsters hamster in newHamsters)
                {
                    xmlOut.WriteStartElement("Hamster");
                    xmlOut.WriteElementString("Code", hamster.Code);
                    xmlOut.WriteElementString("Description", hamster.Description);
                    xmlOut.WriteElementString("Price", Convert.ToString(hamster.Price));
                    xmlOut.WriteElementString("InStock", Convert.ToString(hamster.InStock));
                    xmlOut.WriteElementString("Breed", hamster.Breed);
                    xmlOut.WriteElementString("Gender", hamster.Gender);
                    xmlOut.WriteElementString("Image", hamster.Image);
                    xmlOut.WriteEndElement();
                }

                xmlOut.WriteEndElement();

                xmlOut.WriteStartElement("Necessities");

                foreach (Necessities necessity in newNecessities)
                {
                    xmlOut.WriteStartElement("Necessity");
                    xmlOut.WriteElementString("Code", necessity.Code);
                    xmlOut.WriteElementString("Description", necessity.Description);
                    xmlOut.WriteElementString("Price", Convert.ToString(necessity.Price));
                    xmlOut.WriteElementString("InStock", Convert.ToString(necessity.InStock));
                    xmlOut.WriteElementString("Category", necessity.Category);
                    xmlOut.WriteElementString("Colour", necessity.Colour);
                    xmlOut.WriteElementString("Image", necessity.Image);
                    xmlOut.WriteEndElement();
                }

                xmlOut.WriteEndElement();
                xmlOut.WriteEndElement();

                xmlOut.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File Error");
            }
        }

        //Name: GetNecessities
        //Sent: -
        //Return: List<Necessities>
        //Desc: Returns a list of necessities that is read from a text file. Catches exception if problem reading file
        public static List<Necessities> GetNecessities()
        {
            List<Necessities> products = new List<Necessities>();
            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.IgnoreWhitespace = true;
                settings.IgnoreComments = true;

                XmlReader productXml = XmlReader.Create(@"..\..\bin\Files\Products.xml", settings);

                if (productXml.ReadToDescendant("Necessity"))
                {
                    do
                    {
                        Necessities necessity = new Necessities();
                        productXml.ReadStartElement("Necessity");
                        necessity.Code = productXml.ReadElementContentAsString();
                        necessity.Description = productXml.ReadElementContentAsString();
                        necessity.Price = productXml.ReadElementContentAsDecimal();
                        necessity.InStock = productXml.ReadElementContentAsInt();
                        //int amount = productXml.ReadElementContentAsInt();
                        //necessity.SetStock(amount);
                        necessity.Category = productXml.ReadElementContentAsString();
                        necessity.Colour = productXml.ReadElementContentAsString();
                        necessity.Image = productXml.ReadElementContentAsString();
                        products.Add(necessity);
                    }
                    while (productXml.ReadToNextSibling("Necessity"));
                }
                productXml.Close();

                return products;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File Error");
                return null;
            }
        }

        //Name: GetHamsters
        //Sent: -
        //Return: List<Hamsters>
        //Desc: Returns a list of hamsters that is read from a text file. Catches exception if problem reading file
        public static List<Hamsters> GetHamsters()
        {
            List<Hamsters> products = new List<Hamsters>();
            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.IgnoreWhitespace = true;
                settings.IgnoreComments = true;

                XmlReader productXml = XmlReader.Create(@"..\..\bin\Files\Products.xml", settings);

                if (productXml.ReadToDescendant("Hamster"))
                {
                    do
                    {
                        Hamsters hamster = new Hamsters();
                        productXml.ReadStartElement("Hamster");
                        hamster.Code = productXml.ReadElementContentAsString();
                        hamster.Description = productXml.ReadElementContentAsString();
                        hamster.Price = productXml.ReadElementContentAsDecimal();
                        hamster.InStock = productXml.ReadElementContentAsInt();
                        //int amount = productXml.ReadElementContentAsInt();
                        //hamster.SetStock(amount);
                        hamster.Breed = productXml.ReadElementContentAsString();
                        hamster.Gender = productXml.ReadElementContentAsString();
                        hamster.Image = productXml.ReadElementContentAsString();
                        products.Add(hamster);
                    }
                    while (productXml.ReadToNextSibling("Hamster"));
                }
                productXml.Close();

                return products;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File Error");
                return null;
            }
        }

        //Name: SaveOrder
        //Sent: customer object, string, decimal
        //Return: -
        //Desc: Saves all the order information into a txt file.
        public static void SaveOrder(Customer inCustomer, string path, decimal inTax)
        {
            try
            {
                StreamWriter usersFile = new StreamWriter(path);

                usersFile.WriteLine("Order Reciept for " + inCustomer.Name + "\n");
                usersFile.WriteLine(String.Format("{0,-20}{1,-70}{2,-35}{3,0}", "Code", "Name", "Details", "Price"));
                foreach (Products item in inCustomer.Cart)
                {
                    usersFile.WriteLine(item.DisplayProduct());
                }
                decimal subTotal = inCustomer.GetSubTotal();
                usersFile.WriteLine(String.Format("\n{0,135}", "Subtotal: " + subTotal.ToString("c2")));
                usersFile.WriteLine(String.Format("{0,135}", "Tax (" + inTax.ToString("p") + "): " + (subTotal * inTax).ToString("c2")));
                usersFile.WriteLine(String.Format("{0,135}", "Total: " + (subTotal + (subTotal * inTax)).ToString("c2")));

                usersFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File Error");
            }
        }
    }
}

