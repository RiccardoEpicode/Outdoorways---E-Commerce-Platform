# Outdoorways – Applicazione E-Commerce ASP.NET MVC

Outdoorways è una piattaforma e-commerce completa sviluppata con ASP.NET Core MVC, Entity Framework Core, SQL Server e Bootstrap.  
Il progetto rappresenta un esempio reale di sito di vendita online, con gestione prodotti, categorie, carrello e sezione amministrativa per l’inventario.

---

## Presentazione del Progetto

![Outdoorways](wwwroot/images/Presentazione.gif)

---

## ## Funzionalità Principali

- Navigazione prodotti per categoria:
  - Men, Women, Kids, Winter, Summer, Spring, Autumn
- Pagina generale *Shop All*
- Pagina *Details* del prodotto con:
  - immagine
  - descrizione
  - categoria
  - prezzo
  - selezione quantità
- Sistema di carrello:
  - aggiunta prodotti
  - quantità modificabile
  - totale automatico
  - lista temporanea lato server

### Funzionalità Admin – Inventory Management
- Aggiunta nuovi prodotti
- Modifica prodotti esistenti
- Eliminazione prodotti
- Scelta categoria tramite dropdown
- Gestione completa:
  - nome
  - descrizione
  - prezzo
  - quantità
  - immagine (nome file)
  - categoria

---

## ## Stack Tecnologico

### Backend
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server Express
- Dependency Injection

### Frontend
- Bootstrap 5
- Razor Views
- Layout responsive

---

## ## Database e Relazioni

![ERD](wwwroot/images/ERD.jpg)


Tabelle principali:
- Categories  
- Products  
- Users  
- Orders  
- OrderItems  

Relazioni:
- Category 1 → N Products  
- User 1 → N Orders  
- Order 1 → N OrderItems  
- OrderItem → Product (FK)

---

## ## Caratteristiche Tecniche Implementate

- Entity Framework Core Fluent API
- Seed Data iniziale per categorie, prodotti e admin
- CRUD completo lato amministrazione
- Sistema per categorie dinamiche
- Carrello gestito tramite lista statica (versione semplificata)
- Routing MVC
- Migrations EF Core:

## ## Autore

**Riccardo Reali**  
Developer – ASP.NET Core, MVC, SQL, Web Development
