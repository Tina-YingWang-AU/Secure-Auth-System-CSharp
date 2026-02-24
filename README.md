# Secure User Authentication System (C#)

A robust console-based security suite focusing on user identity verification and dynamic data management. This project demonstrates high-level logic flow and defensive programming in C#.

## 📌 Project Overview
This application provides a comprehensive user authentication workflow. It not only verifies existing users but also manages security risks through a lockout mechanism and allows for dynamic system expansion via new user registration.

## 🛠️ Technical Highlights
* **Dictionary Optimization**: Leveraged `Dictionary<string, string>` with `StringComparer.OrdinalIgnoreCase` for high-performance, case-insensitive data lookups.
* **Security Gatekeeping**: Integrated a brute-force prevention mechanism (Account Lockout) that triggers after 3 failed login attempts.
* **Data Integrity**: Features real-time duplication checks during new user registration to ensure system consistency.
* **User Experience**: Integrated input sanitization (`Trim`, `ToLower`) to ensure a smooth and forgiving user interface.

## 💻 Tech Stack & Concepts
* **Language**: C# (.NET Core)
* **Data Structures**: Hash-based Dictionaries (Key-Value Pairs)
* **Concepts**: Logic Flow Control, Error Handling, Authentication Gatekeeping.

---
**Author**: Tina Ying Wang  
**Institution**: TAFE NSW
