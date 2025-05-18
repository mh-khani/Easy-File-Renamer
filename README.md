# 🔄 Easy File Renamer – Easily Rename Multiple Files with One Click ✂️🗂️

A simple 🎯 C# Windows Forms application that allows users to batch rename multiple files 📁 using custom names entered in a textbox. The app also supports adding 🔤 prefixes and suffixes, as well as automatic numbering or lettering.

---

![Screenshot](Media/rec.gif)

---

## ✨ Features

✅ Select multiple files using a file picker  
🧩 View original filenames (name + extension) in a clean, numbered list  
📝 Enter new names (one per line) in a textbox  
🧷 Add **prefix** and/or **suffix** to new filenames  
🔢 Enable **Auto Numbering** (1, 2, 3...) or **Auto Lettering** (A, B, C...) as suffix  
👀 Preview renaming result before applying  
📌 Rename files while preserving their original extensions  
🛡️ Error handling for:
- 🔢 Name count mismatch
- 🚫 Invalid or forbidden characters
- ⚠️ File system errors (e.g., permission denied)

---

## 🖼️ UI Overview

📂 **Open Files**: Select multiple files from your system  
🖊️ **New Names Textbox**: Type the new names, each on a separate line  
🔠 **Prefix/Suffix Inputs**: Optional text to add before/after names  
🔢 **Auto Suffix Options**: 
- Auto Numbering → `filename1.ext`, `filename2.ext`  
- Auto Lettering → `filenameA.ext`, `filenameB.ext`  
🔍 **Preview**: Shows a list like `oldname.ext → newname.ext`  
📁 **Change File Names**: Renames all selected files

---

## 🚀 How to Use

1. 📥 Clone the repository or download the `.exe`  
2. ▶️ Run the application  
3. 📑 Click **Open Files** and select files  
4. ✏️ Enter new names (one per line) — same count as files  
5. 🔧 (Optional) Add prefix, suffix, or enable auto numbering/lettering  
7. ✅ Click **Change File Names** to apply changes

---

## ⚙️ Tech Stack

- 🧠 **Language**: C#  
- 💻 **Framework**: .NET Framework (Windows Forms)

---

## 📌 Notes

⚠️ File extensions are preserved automatically  
🚫 Invalid characters like `\ / : * ? " < > |` are not allowed  
📛 Files will not be overwritten if a duplicate name exists  
👁️ Always use **Preview** to confirm the rename operation

---

## 🪪 License

📄 MIT License – Free to use, modify, and share.
