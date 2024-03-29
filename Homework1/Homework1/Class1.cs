﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace Homework1
{
    public class FileParser
    {
        public myFile[] getFile(String path)
        {
            myFile[] result = null;
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                FileInfo[] inf = dir.GetFiles();
                DirectoryInfo[] subdirs = dir.GetDirectories();
                result = new myFile[inf.Length + subdirs.Length];
                //add the dirs to the result
                for (int i = 0; i < subdirs.Length; i++)
                {
                    result[i] = new myFile(true, subdirs[i].Name,0, subdirs[i].CreationTime.ToString());
                }

                //add the files to the result
                for (int i = 0; i < inf.Length; i++)
                {
                    result[i + subdirs.Length] = new myFile(false,inf[i].Name , inf[i].Length, inf[i].CreationTime.ToString());
                }

                return result;
            }catch (DirectoryNotFoundException)
            {
                result = new myFile[1];
                result[0] = new myFile(false,"Directory is Not Found.Please Check your Path and try again.",0,"");
                return result;
            }
        }

        public bool deleteFile(String path)
        {
            //判断文件是不是存在
            if (File.Exists(path))
            {
                //如果存在则删除文件到回收站
                FileSystem.DeleteFile(path, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                return true;
            }
            return false;
        }

        public myFile[] getFilebyName(String path)
        {
            myFile[] result = null;
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                FileInfo[] inf = dir.GetFiles();
                DirectoryInfo[] subdirs = dir.GetDirectories();
                result = new myFileSortName[inf.Length + subdirs.Length];
                //add the dirs to the result
                for (int i = 0; i < subdirs.Length; i++)
                {
                    result[i] = new myFileSortName(true, subdirs[i].Name, 0, subdirs[i].CreationTime.ToString());
                }

                //add the files to the result
                for (int i = 0; i < inf.Length; i++)
                {
                    result[i + subdirs.Length] = new myFileSortName(false, inf[i].Name, inf[i].Length, inf[i].CreationTime.ToString());
                }
                Array.Sort(result);
                return result;
            }
            catch (DirectoryNotFoundException)
            {
                result = new myFile[1];
                result[0] = new myFile(false, "Directory is Not Found.Please Check your Path and try again.", 0, "");
                return result;
            }
        }

        public myFile[] getFilebyCreationtime(String path)
        {
            myFile[] result = null;
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                FileInfo[] inf = dir.GetFiles();
                DirectoryInfo[] subdirs = dir.GetDirectories();
                result = new myFileSortCreationTime[inf.Length + subdirs.Length];
                //add the dirs to the result
                for (int i = 0; i < subdirs.Length; i++)
                {
                    result[i] = new myFileSortCreationTime(true, subdirs[i].Name, 0, subdirs[i].CreationTime.ToString());
                }

                //add the files to the result
                for (int i = 0; i < inf.Length; i++)
                {
                    result[i + subdirs.Length] = new myFileSortCreationTime(false, inf[i].Name, inf[i].Length, inf[i].CreationTime.ToString());
                }
                Array.Sort(result);
                return result;
            }
            catch (DirectoryNotFoundException)
            {
                result = new myFile[1];
                result[0] = new myFile(false, "Directory is Not Found.Please Check your Path and try again.", 0, "");
                return result;
            }
        }
    }

    public class myFile
    {
        private bool isDir;
        private String name;
        private String size;
        private String createTime;
        public bool getIsDir()
        {
            return isDir;
        }
        public String getName()
        {
            return name;
        }
        public String getCreateTime()
        {
            return createTime;
        }
        public String getSize()
        {
            return size;
        }
        private void setSize(long len)
        {
            //count the size of the file
            if ((double)len / 1024 < 1)
                size = Math.Round((double)len, 2) + "B";
            else if ((double)len / (1024 * 1024) < 1)
                size = Math.Round((double)len / 1024) + "KB";
            else if ((double)len / (1024 * 1024 * 1024) < 1)
                size = Math.Round((double)len / (1024 * 1024)) + "MB";
            else
                size = Math.Round((double)len / (1024 * 1024 * 1024)) + "G";
        }
        public myFile(bool isDir,String name,long size,String createTime)
        {
            this.isDir = isDir;
            this.name = name;
            this.setSize(size);
            this.createTime = createTime;
        }
    }

    public class myFileSortCreationTime:myFile,IComparable
    {
        public myFileSortCreationTime(bool isDir, String name, long size, String createTime)
            : base(isDir, name, size, createTime)
        {
          
        }

#region IComparable
        public int CompareTo(object obj)
        {
            myFileSortCreationTime m = obj as myFileSortCreationTime;
            if (m == null)
                throw new NotImplementedException();
            return this.getCreateTime().CompareTo(m.getCreateTime());
        }
#endregion
    }




    public class myFileSortName : myFile,IComparable
    {
        public myFileSortName(bool isDir,String name,long size,String createTime):base(isDir,name,size,createTime)
        {
          
        }

#region IComparable
        public int CompareTo(object obj)
        {
            myFileSortName m = obj as myFileSortName;
            if (m == null)
                throw new NotImplementedException();
            return this.getName().CompareTo(m.getName());
        }
#endregion
    }

}
