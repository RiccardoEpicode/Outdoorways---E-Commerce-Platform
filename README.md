# Outdoorways – Applicazione E-Commerce ASP.NET MVC

Outdoorways è una piattaforma e-commerce realizzata con **ASP.NET Core MVC**, **Entity Framework Core**, **SQL Server** e **Bootstrap**, progettata come progetto completo per mostrare un flusso reale di un negozio online: prodotti, categorie, carrello e gestione inventario.

---

PER ACCEDERE AL DBSM(DATABASE MANAGEMENT SYSTEM) DI GESTIONE PRODOTTI QUESTO E' IL PATH DA UTILIZZARE http://localhost:5141/InventoryManagement/InventoryManagement

## 📸 Presentazione del Progetto

![Presentazione del Progetto](wwwroot/images/Presentazione.gif)

---

## 🚀 Funzionalità Principali

### Navigazione Prodotti
- Categorie disponibili:
  - **Men**, **Women**, **Kids**
  - **Winter**, **Summer**, **Spring**, **Autumn**
- Pagina generale *Shop All*
- Pagina *Dettagli Prodotto* con:
  - immagine principale
  - categoria
  - descrizione
  - prezzo
  - selezione quantità
  - pulsante *Add to Cart*

### 🛒 Sistema di Carrello
- Aggiunta prodotti con quantità variabile
- Lista persistente lato server (versione semplificata)
- Calcolo automatico del totale
- Visualizzazione riepilogo carrello

### 🛠 Funzionalità Admin – Inventory Management
- Aggiunta nuovi prodotti tramite form dedicato
- Modifica prodotti esistenti
- Eliminazione prodotti
- Dropdown dinamico per scelta categoria
- Gestione attributi prodotto:
  - nome
  - descrizione
  - prezzo
  - quantità in magazzino
  - immagine tramite filename
  - categoria

---

## 🧱 Stack Tecnologico

### Backend
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server Express
- Dependency Injection
- Model Binding & Routing

### Frontend
- Bootstrap 5
- Razor Views
- Layout responsivo
- Validazione lato client

---

## 🗂 Struttura Database & Relazioni

![ERD del Database](wwwroot/images/ERD.jpg)

**Tabelle principali:**
- `Categories`
- `Products`
- `Users`
- `Orders`
- `OrderItems`

**Relazioni:**
- Una *Category* → molti *Products*
- Un *User* → molti *Orders*
- Un *Order* → molti *OrderItems*
- Un *OrderItem* → un *Product*

---

## ⚙️ Funzionalità Tecniche Implementate

- Entity Framework Core con Migrations
- Seed Data iniziale per categorie e prodotti
- CRUD completo lato amministrazione
- Gestione delle categorie tramite DB
- Carrello con lista statica (implementazione basic)
- Uso di ViewModel, ViewBag, Razor e Layout condiviso
- Routing MVC e action methods REST-like
- Validazioni con DataAnnotations

---

## 👨‍💻 Autore

**Riccardo Reali**  
Developer – ASP.NET Core, MVC, SQL, Web Development
