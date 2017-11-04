using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.IO;

namespace FTPClient
{
    public partial class Form1 : Form
    {
        static String url;
        static String pathDisplay, pathDownload;
        static String username;
        static String password;
        static int numberOfTimes = 0;
                 
        public Form1()
        {
            InitializeComponent();
        }

        private void displayB_Click(object sender, EventArgs e)
        {
            url = addressBarTE.Text.ToString();
            username = userTE.Text.ToString();
            password = pasTE.Text.ToString();

            try
            {
                FtpWebRequest req;
                String path = "";
                int itemCounts = contentLB.Items.Count;
                for (int j = itemCounts - 1; j >= 0; j--)
                    if (contentLB.GetSelected(j) == true)
                    {
                        path = contentLB.SelectedItem.ToString();
                        addressBarTE.Text = url + "/" + path;
                        url = addressBarTE.Text.ToString();
                        break;
                    }
                //MessageBox.Show("ftp://" + url.ToString());

                req = (FtpWebRequest)WebRequest.Create("ftp://" + url); //vasl shodan b address-i k dar addressbar hast
                req.Method = WebRequestMethods.Ftp.ListDirectory; //gereftane list folder haie k dar ftp hast
                req.Credentials = new NetworkCredential(username, password); //ersale username va password b server

                FtpWebResponse res = (FtpWebResponse)req.GetResponse(); //bargasht-e code javabe server baraye request-e ferestade shode

                Stream resStream = res.GetResponseStream(); //bargasht-e strema-e javabe server baraye request-e ferestade shode
                StreamReader reader = new StreamReader(resStream);

                if (numberOfTimes > 0)
                {
                    for (int i = (itemCounts - 1); i >= 0; i--)
                        contentLB.Items.RemoveAt(i);
                }

                while (!reader.EndOfStream)
                    contentLB.Items.Add(reader.ReadLine());

                

                numberOfTimes++;

                reader.Close();
                res.Close();
            }
            catch (WebException exc)
            {
                MessageBox.Show("Network Error: " + exc.Message + "\nStatus code: " + exc.Status);
            }
            catch (ProtocolViolationException exc)
            {
                MessageBox.Show("Protocol Error: " + exc.Message);
            }
            catch (UriFormatException exc)
            {
                MessageBox.Show("URI Format Error: " + exc.Message);
            }
            catch (NotSupportedException exc)
            {
                MessageBox.Show("Unknown Protocol: " + exc.Message);
            }
            catch (IOException exc)
            {
                MessageBox.Show("I/O Error: " + exc.Message);
            }
            catch (System.Security.SecurityException exc)
            {
                MessageBox.Show("Security Exception: " + exc.Message);
            }
            catch (InvalidOperationException exc)
            {
                MessageBox.Show("Invalid Operation: " + exc.Message);
            }
        }

        private void downloadB_Click(object sender, EventArgs e)
        {
            url = addressBarTE.Text.ToString();
            username = userTE.Text.ToString();
            password = pasTE.Text.ToString();

            try
            {
                //FtpWebRequest req;
                String path = "";
                int itemCounts = contentLB.Items.Count;
                for (int j = itemCounts - 1; j >= 0; j--)
                    if (contentLB.GetSelected(j) == true)
                    {
                        path = contentLB.SelectedItem.ToString();
                        //addressBarTE.Text = url + "/" + path;
                        url = url + "/" + path;
                        break;
                    }
                //req = (FtpWebRequest)WebRequest.Create("ftp://" + url);
                //req.Method = WebRequestMethods.Ftp.DownloadFile;
                //req.Credentials = new NetworkCredential(username, password);
                WebClient req = new WebClient();
                req.Credentials = new NetworkCredential(username, password);
                
                byte[] fileData = req.DownloadData("ftp://" + url);
                
                FileStream file = File.Create(downloadTB.Text.ToString() + path);

                file.Write(fileData, 0, fileData.Length);

                MessageBox.Show("Download Completed :)))");

                //FtpWebResponse res = (FtpWebResponse)req.GetResponse();

                //Stream resStream = res.GetResponseStream();
                //StreamReader reader = new StreamReader(resStream);

                //Console.WriteLine(reader.ReadToEnd());
                /*if (numberOfTimes > 0)
                {
                    outputRTB.Text = " ";
                    //for (int i = (itemCounts - 1); i >= 0; i--)
                      //  contentLB.Items.RemoveAt(i);
                }*/

                //while (!reader.EndOfStream)
                  //  contentLB.Items.Add(reader.ReadLine());
                //outputRTB.Text = reader.ReadToEnd().ToString();



                numberOfTimes++;

                //reader.Close();
                //res.Close();
            }
            catch (WebException exc)
            {
                MessageBox.Show("Network Error: " + exc.Message + "\nStatus code: " + exc.Status);
            }
            catch (ProtocolViolationException exc)
            {
                MessageBox.Show("Protocol Error: " + exc.Message);
            }
            catch (UriFormatException exc)
            {
                MessageBox.Show("URI Format Error: " + exc.Message);
            }
            catch (NotSupportedException exc)
            {
                MessageBox.Show("Unknown Protocol: " + exc.Message);
            }
            catch (IOException exc)
            {
                MessageBox.Show("I/O Error: " + exc.Message);
            }
            catch (System.Security.SecurityException exc)
            {
                MessageBox.Show("Security Exception: " + exc.Message);
            }
            catch (InvalidOperationException exc)
            {
                MessageBox.Show("Invalid Operation: " + exc.Message);
            }
        }

        private void uploadB_Click(object sender, EventArgs e)
        {
            url = addressBarTE.Text.ToString();
            username = userTE.Text.ToString();
            password = pasTE.Text.ToString();
            try
            {
                for (int i = 0; i < 2; i++)
                {
                    FileInfo toUpload = new FileInfo(uploadTB.Text.ToString());
                    FileInfo toUpload2 = new FileInfo(uploadTB2.Text.ToString());

                    FtpWebRequest req = (FtpWebRequest)WebRequest.Create("ftp://" + url + "/" + toUpload.Name);
                    FtpWebRequest req2 = (FtpWebRequest)WebRequest.Create("ftp://" + url + "/" + toUpload2.Name);
                    //MessageBox.Show("1");
                    req.Method = WebRequestMethods.Ftp.UploadFile;
                    req2.Method = WebRequestMethods.Ftp.UploadFile;
                    //MessageBox.Show("2");
                    req.Credentials = new NetworkCredential(username, password);
                    req2.Credentials = new NetworkCredential(username, password);
                    //MessageBox.Show("3   " + "ftp://" + url + "/" + toUpload.Name);

                    Stream str = req.GetRequestStream();
                    Stream str2 = req2.GetRequestStream();
                    //MessageBox.Show("4");
                    FileStream file = File.OpenRead(uploadTB.Text.ToString());
                    FileStream file2 = File.OpenRead(uploadTB2.Text.ToString());
                    //MessageBox.Show("5");

                    int length = 1024;
                    byte[] buffer = new byte[length];
                    int byteRead = 0;

                    do
                    {
                        byteRead = file.Read(buffer, 0, length);
                        str.Write(buffer, 0, byteRead);
                    }
                    while (byteRead != 0);

                    do
                    {
                        byteRead = file2.Read(buffer, 0, length);
                        str2.Write(buffer, 0, byteRead);
                    }
                    while (byteRead != 0);

                    file.Close();
                    str.Close();
                    file2.Close();
                    str2.Close();

                    
                    FtpWebRequest req3 = (FtpWebRequest)WebRequest.Create("ftp://" + addressBarTE.Text.ToString());
                    req3.Method = WebRequestMethods.Ftp.ListDirectory;
                    req3.Credentials = new NetworkCredential(username, password);

                    FtpWebResponse resq3 = (FtpWebResponse)req3.GetResponse();

                    Stream resStream3 = resq3.GetResponseStream();
                    StreamReader reader3 = new StreamReader(resStream3);

                    int itemCounts = contentLB.Items.Count;
                    if (numberOfTimes > 0)
                    {
                        for (int j = (itemCounts - 1); j >= 0; j--)
                            contentLB.Items.RemoveAt(j);
                    }

                    while (!reader3.EndOfStream)
                        contentLB.Items.Add(reader3.ReadLine());
                    resq3.Close();
                }
                
                
                MessageBox.Show("Upload Completed :)))");
            }
            catch (WebException exc)
            {
                MessageBox.Show("Network Error: " + exc.Message + "\nStatus code: " + exc.Status);
            }
            catch (ProtocolViolationException exc)
            {
                MessageBox.Show("Protocol Error: " + exc.Message);
            }
            catch (UriFormatException exc)
            {
                MessageBox.Show("URI Format Error: " + exc.Message);
            }
            catch (NotSupportedException exc)
            {
                MessageBox.Show("Unknown Protocol: " + exc.Message);
            }
            catch (IOException exc)
            {
                MessageBox.Show("I/O Error: " + exc.Message);
            }
            catch (System.Security.SecurityException exc)
            {
                MessageBox.Show("Security Exception: " + exc.Message);
            }
            catch (InvalidOperationException exc)
            {
                MessageBox.Show("Invalid Operation: " + exc.Message);
            }

            
        }

        private void directoryB_Click(object sender, EventArgs e)
        {
            url = addressBarTE.Text.ToString();
            username = userTE.Text.ToString();
            password = pasTE.Text.ToString();
            try{
                FtpWebRequest req = (FtpWebRequest)WebRequest.Create("ftp://" + url + "/" + makedirectoryTB.Text.ToString());
                req.Method = WebRequestMethods.Ftp.MakeDirectory;
    
                req.Credentials = new NetworkCredential(username, password);
                    
                FtpWebResponse ftpResp = (FtpWebResponse)req.GetResponse();

                FtpWebRequest req3 = (FtpWebRequest)WebRequest.Create("ftp://" + addressBarTE.Text.ToString());
                req3.Method = WebRequestMethods.Ftp.ListDirectory;
                req3.Credentials = new NetworkCredential(username, password);

                FtpWebResponse resq3 = (FtpWebResponse)req3.GetResponse();

                Stream resStream3 = resq3.GetResponseStream();
                StreamReader reader3 = new StreamReader(resStream3);

                int itemCounts = contentLB.Items.Count;
                if (numberOfTimes > 0)
                {
                    for (int j = (itemCounts - 1); j >= 0; j--)
                        contentLB.Items.RemoveAt(j);
                }

                while (!reader3.EndOfStream)
                    contentLB.Items.Add(reader3.ReadLine());
                resq3.Close();
            }
            catch (WebException exc)
            {
                MessageBox.Show("Network Error: " + exc.Message + "\nStatus code: " + exc.Status);
            }
            catch (ProtocolViolationException exc)
            {
                MessageBox.Show("Protocol Error: " + exc.Message);
            }
            catch (UriFormatException exc)
            {
                MessageBox.Show("URI Format Error: " + exc.Message);
            }
            catch (NotSupportedException exc)
            {
                MessageBox.Show("Unknown Protocol: " + exc.Message);
            }
            catch (IOException exc)
            {
                MessageBox.Show("I/O Error: " + exc.Message);
            }
            catch (System.Security.SecurityException exc)
            {
                MessageBox.Show("Security Exception: " + exc.Message);
            }
            catch (InvalidOperationException exc)
            {
                MessageBox.Show("Invalid Operation: " + exc.Message);
            }

        }

        private void moveB_Click(object sender, EventArgs e)
        {
            url = addressBarTE.Text.ToString();
            username = userTE.Text.ToString();
            password = pasTE.Text.ToString();
            try
            {
                //down
                String path = "";
                int itemCounts = contentLB.Items.Count;
                for (int j = itemCounts - 1; j >= 0; j--)
                    if (contentLB.GetSelected(j) == true)
                    {
                        path = contentLB.SelectedItem.ToString();
                        //addressBarTE.Text = url + "/" + path;
                        url = url + "/" + path;
                        break;
                    }
                WebClient req = new WebClient();
                req.Credentials = new NetworkCredential(username, password);
                //MessageBox.Show("-5");
                byte[] fileData = req.DownloadData("ftp://" + url);
                //MessageBox.Show("-4");
                FileStream file = File.Create(downloadTB.Text.ToString() + path);
                //MessageBox.Show("-3");
                file.Write(fileData, 0, fileData.Length);
                //MessageBox.Show("-2");
                file.Close();

                //MessageBox.Show("1");
                //up
                FileInfo toUpload = new FileInfo(downloadTB.Text.ToString() + path);
                MessageBox.Show(toUpload.Name);

                FtpWebRequest req2 = (FtpWebRequest)WebRequest.Create("ftp://" + addressBarTE.Text.ToString() + "/" + destinationTB.Text.ToString() + "/" + toUpload.Name);
                MessageBox.Show("ftp://" + addressBarTE.Text.ToString() + "/" + destinationTB.Text.ToString() + "/" + toUpload.Name);
                //MessageBox.Show("2");
                req2.Method = WebRequestMethods.Ftp.UploadFile;
                //MessageBox.Show("3");
                req2.Credentials = new NetworkCredential(username, password);
                //MessageBox.Show("4");

                //FtpWebResponse res = (FtpWebResponse)req.GetResponse();

                Stream str = req2.GetRequestStream();
                //MessageBox.Show("5");
                //MessageBox.Show(downloadTB.Text.ToString() + path);
                FileStream file2 = File.OpenRead(downloadTB.Text.ToString() + path);
                //MessageBox.Show("6");

                int length = 1024;
                byte[] buffer = new byte[length];
                int byteRead = 0;

                do
                {
                    byteRead = file2.Read(buffer, 0, length);
                    str.Write(buffer, 0, byteRead);
                }
                while (byteRead != 0);
                file2.Close();
                str.Close();
                //MessageBox.Show("7");


                //del
                FtpWebRequest req3 = (FtpWebRequest)WebRequest.Create("ftp://" + url);
                //MessageBox.Show("8");
                req3.Method = WebRequestMethods.Ftp.DeleteFile;
                //MessageBox.Show("9");
                req3.Credentials = new NetworkCredential(username, password);

                FtpWebResponse res3 = (FtpWebResponse)req3.GetResponse();
                //MessageBox.Show("10");
                MessageBox.Show("File moved :)))");
                req3 = (FtpWebRequest)WebRequest.Create("ftp://" + addressBarTE.Text.ToString());
                req3.Method = WebRequestMethods.Ftp.ListDirectory;
                req3.Credentials = new NetworkCredential(username, password);

                FtpWebResponse resq3 = (FtpWebResponse)req3.GetResponse();

                Stream resStream3 = resq3.GetResponseStream();
                StreamReader reader3 = new StreamReader(resStream3);

                if (numberOfTimes > 0)
                {
                    for (int i = (itemCounts - 1); i >= 0; i--)
                        contentLB.Items.RemoveAt(i);
                }

                while (!reader3.EndOfStream)
                    contentLB.Items.Add(reader3.ReadLine());
                res3.Close();
                reader3.Close();

            }
            catch (WebException exc)
            {
                MessageBox.Show("Network Error: " + exc.Message + "\nStatus code: " + exc.Status);
            }
            catch (ProtocolViolationException exc)
            {
                MessageBox.Show("Protocol Error: " + exc.Message);
            }
            catch (UriFormatException exc)
            {
                MessageBox.Show("URI Format Error: " + exc.Message);
            }
            catch (NotSupportedException exc)
            {
                MessageBox.Show("Unknown Protocol: " + exc.Message);
            }
            catch (IOException exc)
            {
                MessageBox.Show("I/O Error: " + exc.Message);
            }
            catch (System.Security.SecurityException exc)
            {
                MessageBox.Show("Security Exception: " + exc.Message);
            }
            catch (InvalidOperationException exc)
            {
                MessageBox.Show("Invalid Operation: " + exc.Message);
            }
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            url = addressBarTE.Text.ToString();
            username = userTE.Text.ToString();
            password = pasTE.Text.ToString();

            try
            {
                String path = "";
                int itemCounts = contentLB.Items.Count;
                for (int j = itemCounts - 1; j >= 0; j--)
                    if (contentLB.GetSelected(j) == true)
                    {
                        path = contentLB.SelectedItem.ToString();
                        //addressBarTE.Text = url + "/" + path;
                        url = url + "/" + path;
                        break;
                    }
                //MessageBox.Show("1");
                FtpWebRequest req = (FtpWebRequest)WebRequest.Create("ftp://" + url);
                //MessageBox.Show("2");
                req.Method = WebRequestMethods.Ftp.DeleteFile;
                //MessageBox.Show("3");
                req.Credentials = new NetworkCredential(username, password);

                FtpWebResponse res = (FtpWebResponse)req.GetResponse();
                //MessageBox.Show("4");
                MessageBox.Show("File deleted :)))");
                req = (FtpWebRequest)WebRequest.Create("ftp://" + addressBarTE.Text.ToString());
                req.Method = WebRequestMethods.Ftp.ListDirectory;
                req.Credentials = new NetworkCredential(username, password);

                FtpWebResponse resq = (FtpWebResponse)req.GetResponse();

                Stream resStream = resq.GetResponseStream();
                StreamReader reader = new StreamReader(resStream);

                if (numberOfTimes > 0)
                {
                    for (int i = (itemCounts - 1); i >= 0; i--)
                        contentLB.Items.RemoveAt(i);
                }

                while (!reader.EndOfStream)
                    contentLB.Items.Add(reader.ReadLine());
                res.Close();
            }
            catch (WebException exc)
            {
                MessageBox.Show("Network Error: " + exc.Message + "\nStatus code: " + exc.Status);
            }
            catch (ProtocolViolationException exc)
            {
                MessageBox.Show("Protocol Error: " + exc.Message);
            }
            catch (UriFormatException exc)
            {
                MessageBox.Show("URI Format Error: " + exc.Message);
            }
            catch (NotSupportedException exc)
            {
                MessageBox.Show("Unknown Protocol: " + exc.Message);
            }
            catch (IOException exc)
            {
                MessageBox.Show("I/O Error: " + exc.Message);
            }
            catch (System.Security.SecurityException exc)
            {
                MessageBox.Show("Security Exception: " + exc.Message);
            }
            catch (InvalidOperationException exc)
            {
                MessageBox.Show("Invalid Operation: " + exc.Message);
            }
        }

        

        

       
    }
}
