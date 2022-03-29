using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Sheduler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddNewNoteEvent(object sender, EventArgs e)
        {
            XmlManager.CreateNewNote(name: "NewNote", text: "YourText"); // Создаём новую заметку
        }
    }

    public static class XmlManager
    {
        public static void CreateNewNote(string name, string text) //метод для создания заметок
        {
            XmlDocument xDoc = new XmlDocument(); 
            xDoc.Load("NotesList.xml"); // загружем xml-файл
            XmlElement rNode = xDoc.DocumentElement; // вытаскиваем корневой узел

            // Структуру xml-документа смотри в шаблоне


            // Создание узлов
            XmlElement note = xDoc.CreateElement("note"); 
            XmlAttribute noteNameAttr = xDoc.CreateAttribute("name");
            XmlElement noteText = xDoc.CreateElement("noteText");

            // Создание текстовых значений для атрибутов и узлов
            XmlText noteTextVal = xDoc.CreateTextNode(text);
            XmlText noteNameAttrVal = xDoc.CreateTextNode(name);

            // Добавление значений
            noteNameAttr.AppendChild(noteNameAttrVal);
            noteText.AppendChild(noteTextVal);

            // Создание узлов
            note.Attributes.Append(noteNameAttr);
            note.AppendChild(noteText);

            // Добавляем новую заметку в корневой узел
            rNode.AppendChild(note);

            // Сохраняем изменения
            xDoc.Save("NotesList.xml");
;        }
    }
}
