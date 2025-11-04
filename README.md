# 🍔 Builder Design Pattern — Burger Builder Example (C#)
<p align="center">
  <a href="https://learn.microsoft.com/en-us/dotnet/csharp/">
    <img src="https://upload.wikimedia.org/wikipedia/commons/4/4f/Csharp_Logo.png" alt="C# Logo" width="150"/>
  </a>
</p>

---

This project demonstrates the **Builder Design Pattern** using a **custom burger order** example in C#.

The builder pattern allows you to **construct complex objects step-by-step**, separating the construction process from the final representation.  
In this example, a **Chef** uses different builders to prepare different types of burgers (Classic and Vegan) using the same sequence of steps.

---

## 🏗️ How It Works

1. **Burger** – The final product being built.  
2. **IBurgerBuilder** – Defines the steps required to build a burger.  
3. **ClassicBurgerBuilder** & **VeganBurgerBuilder** – Implement the steps differently for each burger type.  
4. **Chef (Director)** – Directs the construction process using a builder.  
5. **Program (Client)** – Chooses which burger to make and displays the result.

---

## 💡 Pattern Type
**Creational Design Pattern**

---

## ⚙️ When to Use This Pattern
Use the **Builder Pattern** when:
- The object requires **multiple steps** to be created.  
- You want to **separate the construction logic** from how the object is represented.  
- You need to easily create **different variations** of an object.

---

