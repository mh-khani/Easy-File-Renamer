# 🔄 File Name Changer – Easily Rename Multiple Files with One Click ✂️🗂️

A simple 🎯 C# Windows Forms application that allows users to batch rename multiple files 📁 using custom names entered in a textbox. The app also supports adding 🔤 prefixes and suffixes to filenames.

---
![Screenshot](screenshots/preview.png)

## ✨ Features

✅ Select multiple files using a file picker  
🧩 View original filenames (name + extension) in a clean list  
📝 Enter new names (one per line) in a textbox  
🧷 Add **prefix** and/or **suffix** to new filenames  
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
🔍 **Preview**: Shows a list like `oldname.ext → newname.ext`  
📁 **Change File Names**: Renames all selected files

---

## 🚀 How to Use

1. 📥 Clone the repository or download the `.exe`  
2. ▶️ Run the application  
3. 📑 Click **Open Files** and select files  
4. ✏️ Enter new names (one per line) — same count as files  
5. 🔧 (Optional) Add prefix or suffix  
6. 👁️ Click **Preview**  
7. ✅ Click **Change File Names** to apply

---

## ⚙️ Tech Stack

- 🧠 **Language**: C#  
- 💻 **Framework**: .NET Framework (Windows Forms)

---

## 📌 Notes

⚠️ Extensions are preserved automatically.  
🚫 Invalid characters like `\ / : * ? " < > |` are not allowed.  
📛 Files will not be overwritten if a duplicate name exists.  
👁️ Always use **Preview** to confirm the rename operation.

---

## 🪪 License

📄 MIT License – Free to use, modify, and share.

---

## 📸 Screenshots (optional)

![Screenshot](screenshots/preview.png)
