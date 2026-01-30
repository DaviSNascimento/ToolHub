# 🧰 ToolHub

**ToolHub** is an experimental terminal-based application (TUI/CLI) designed to help users *discover, understand, and learn* the command-line tools available on their system.

Instead of just listing binaries or relying on manuals you already need to know, ToolHub aims to act as a **living catalog of terminal tools**, explaining **what they are**, **why they exist**, and **when to use them** — all directly inside the terminal.

---

## ✨ What problem does ToolHub solve?

When you start using the terminal more often, you quickly face a common problem:

- You *have many tools installed*, but  
- You don’t know **what they are**,  
- You don’t know **why they exist**,  
- And you don’t know **when or how to use them**.

Many tools are installed implicitly as dependencies (`build-essential`, base system packages, etc.), and traditional commands like `ls`, `which`, or `man` assume you already know what you’re looking for.

**ToolHub fills this gap.**

---

## 🎯 Project vision

ToolHub is designed to be:

- 🧭 A **discovery hub** for terminal tools  
- 📚 A **learning-oriented interface**, not just documentation  
- 🖥️ A **terminal-native application** (TUI / CLI)  
- 🧩 Modular, extensible, and community-driven  
- 🐧 Focused on Linux / WSL environments  

The long-term idea is to let users explore tools by **category**, **purpose**, and **usage examples**, instead of memorizing command names.

---

## 🖼️ Interface concept (TUI)

The interface is based on a **grid of categories**, each represented as a visual box inside the terminal:

- Categories displayed side-by-side (grid layout)
- Each category contains multiple tools
- Each tool can later show:
  - Description
  - Example usage
  - Help reference (`man`, links, etc.)
- Designed to be readable, visual, and distraction-free

> Think of it as a *dashboard for your terminal knowledge*.

---

## 🚧 Current status

⚠️ **Early-stage / paused development**

This repository currently contains:
- Project structure and experiments
- Terminal UI layout prototypes using `Spectre.Console`
- No finalized MVP yet

The project is intentionally paused to allow future refinement, feedback, and contribution.

---

## 🧱 Planned MVP scope (when resumed)

- Terminal-based UI (TUI)
- Tool discovery by category
- Human-readable descriptions
- Simple usage examples
- Static data source (JSON/YAML) for easy contributions
- No external services or internet dependency

---

## 🛠️ Tech stack

- **Language:** C# (.NET)
- **UI:** Terminal User Interface (TUI)
- **Library:** [Spectre.Console](https://spectreconsole.net/)
- **Target environment:** Linux / WSL

---

## 🤝 Contributing

This project is intended to be **collaborative and educational**.

Future contributors will be able to:
- Add new tools and categories
- Improve descriptions and examples
- Refine the TUI layout
- Discuss UX ideas for terminal learning

Contribution guidelines will be added when development resumes.

---

## 📌 Why open source?

ToolHub exists because many developers learn the terminal *by accident*, not by design.

By keeping this project open source, the goal is to:
- Share knowledge
- Lower the barrier to terminal literacy
- Create a tool shaped by real user experience

---

## 📄 License

This project is released under the **MIT License**.

---

## 🧠 Final note

ToolHub is not meant to replace `man`, `tldr`, or documentation.

It is meant to answer a simpler question first:

> **“What tools do I have, and why should I care?”**
