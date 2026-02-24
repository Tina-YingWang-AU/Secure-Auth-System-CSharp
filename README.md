# Secure User Management & Authentication Suite (C#)

🌟 **Project Overview**

This project serves as a cornerstone of my transition into C# development within the .NET ecosystem. Moving beyond basic syntax, this system implements a **security-first architecture** designed to handle user identity verification and dynamic account management.

Inspired by enterprise-grade security protocols, this application demonstrates how structured logic can prevent unauthorized access and ensure data integrity in a high-stakes environment.

🚀 **Functional Modules**

The system is engineered as a robust console solution, featuring specialized logic modules to ensure a professional and secure user experience.

### 1. Multi-Factor Authentication Logic
* **Identity Verification**: Implements a high-precision lookup algorithm using C# Dictionaries to validate existing credentials.
* **Anti-Brute Force Gatekeeping**: Features a security layer that monitors failed attempts. To protect system integrity, the account is automatically "locked" after 3 unsuccessful login attempts, mitigating the risk of brute-force attacks.

### 2. Dynamic User Registration Module
* **Uniqueness Validation**: Prior to adding new data, the system performs a real-time scan of the registry to prevent duplicate usernames, ensuring **Data Integrity**.
* **State Persistence Logic**: New users are instantly integrated into the active session, demonstrating dynamic memory management and collection handling.

### 3. Professional User Experience (UX)
* **Input Sanitization**: The system is built to be "crash-proof." By utilizing `int.TryParse` and string normalization (`Trim`/`ToLower`), it gracefully handles invalid characters and unexpected user behavior.
* **Interactive Session Tracking**: Provides real-time feedback on login attempts and system status, maintaining a clear communication loop with the user.

🧠 **Logic Behind the Screen**

🛡️ **Core Security Workflow**
1.  **Normalization**: Every input is sanitized to prevent case-sensitivity errors.
2.  **Validation**: Credentials are cross-referenced against a high-performance `Dictionary<string, string>` (O(1) lookup time).
3.  **Threshold Enforcement**: The system tracks the `loginCount` state; once the threshold is met, the session is terminated to protect the registry.

📐 **Design & Methodology**
Following professional SDLC (Software Development Life Cycle) practices, I prioritized **Defensive Programming**. This ensures that edge cases—such as duplicate registration or non-numeric inputs—are handled through predefined logical paths rather than allowing the program to crash.

📂 **System Architecture**
* **Language**: C# (.NET Core)
* **Data Structure**: Hash-based Dictionaries for optimized credential mapping.
* **Execution Flow**: Controlled through a nested `do-while` architecture to manage complex session states.

🚀 **Learning & Growth Path**
As a **career changer**, this project was instrumental in mastering:
* **Engineering Mindset**: Translating business security requirements into functional C# code.
* **Data Management**: Transitioning from basic arrays to advanced Key-Value pair collections.
* **Robustness**: Building "commercial-grade" validation loops that prioritize system uptime.

---
**Author**: Tina Ying Wang  
**Institution**: TAFE NSW
