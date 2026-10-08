# 🐾 Clinique Vétérinaire — Application de gestion

Application de bureau développée en **C# (Windows Forms)** et connectée à une base de données **SQL Server LocalDB**. Elle permet de gérer les propriétaires, les animaux, les rendez-vous, les consultations, les vaccinations, les médicaments et la facturation d'une clinique vétérinaire.

Projet académique réalisé en groupe de 3 étudiants — Institut Supérieur de Gestion de Tunis (ISG Tunis), licence en Informatique de gestion, année universitaire 2025-2026.

## 🎯 Objectifs

- Centraliser les informations de la clinique
- Améliorer la gestion des rendez-vous
- Assurer le suivi médical des animaux
- Gérer les opérations administratives et financières

## 👥 Rôles et fonctionnalités

L'application propose trois interfaces selon le rôle de l'utilisateur connecté.

| Rôle | Fonctionnalités principales |
|------|-----------------------------|
| **Administrateur** | Gestion des comptes utilisateurs et des rôles (ajout, modification, suppression) ; gestion des médicaments ; tableau de bord (nombre d'utilisateurs, nombre de médicaments, stock total, alertes de stock faible et de produits proches de l'expiration) ; calcul des revenus sur une période |
| **Secrétaire** | Gestion des propriétaires, des animaux et des rendez-vous (animal, vétérinaire, date, heure, motif) ; consultation de l'historique des factures ; recherches multicritères (date, animal, statut) |
| **Vétérinaire** | Consultation du planning ; enregistrement des consultations (diagnostic, traitement, remarques) ; gestion des vaccinations ; utilisation des médicaments avec déduction automatique du stock |

## 🛠️ Technologies

| Composant | Technologie |
|-----------|-------------|
| Langage | C# — .NET Framework 4.8 |
| Interface | Windows Forms |
| Base de données | SQL Server LocalDB (`CliniqueDB.mdf`) |
| Accès aux données | ADO.NET (`System.Data.SqlClient`), requêtes paramétrées |
| Outil | Visual Studio, Git |

## 🏗️ Architecture

Architecture en 3 couches :

| Couche | Composants | Responsabilité |
|--------|------------|----------------|
| Présentation | `LoginForm`, `AdminForm`, `SecretaireForm`, `VeterinaireForm` | Interfaces utilisateur et gestion des événements |
| Métier | `DatabaseHelper`, méthodes CRUD, transactions | Logique applicative et règles métier |
| Données | SQL Server LocalDB — `CliniqueDB.mdf` | Persistance et intégrité des données |

### Points techniques

- **Transaction SQL** lors de l'enregistrement d'une consultation : déduction du stock de médicaments, création de la consultation, génération de la facture et passage du rendez-vous au statut « Terminé » sont validés ensemble (`Commit`) ou tous annulés en cas d'erreur (`Rollback`).
- **Requêtes paramétrées** pour limiter les risques d'injection SQL.
- **Filtres multicritères** construits dynamiquement avec des conditions `WHERE 1=1`.
- **Liaison des ComboBox** à la base via `DisplayMember` et `ValueMember`.

## 🗄️ Base de données

8 tables reliées par des clés étrangères.

| Table | Description |
|-------|-------------|
| `Utilisateurs` | Comptes utilisateurs (Id, Nom, Email, MotDePasse, Role) |
| `Proprietaires` | Propriétaires d'animaux (NomComplet, Téléphone, Email, Adresse) |
| `Animaux` | Animaux (Nom, Espèce, Race, DateNaissance, IdProprietaire) |
| `RendezVous` | Rendez-vous (DateHeure, Motif, IdAnimal, IdVeterinaire, Statut) |
| `Consultations` | Consultations réalisées (Diagnostic, Traitement, Remarques, IdRendezVous) |
| `Vaccinations` | Vaccins administrés (Vaccin, DateAdmin, DateRappel, IdAnimal) |
| `Medicaments` | Stock de médicaments (Nom, StockQuantite, DateExpiration) |
| `Factures` | Factures (Montant, DateFacture, Paye, IdConsultation) |

Relations principales :

```
Proprietaires 1 ── n Animaux 1 ── n RendezVous 1 ── n Consultations 1 ── n Factures
                         │                 │
                         └── n Vaccinations └── n..1 Utilisateurs (vétérinaire)
```

## 🖼️ Captures d'écran

| Connexion | Administrateur |
|-----------|----------------|
| ![Connexion](screenshots/login.png) | ![Admin](screenshots/admin.png) |

| Secrétaire | Vétérinaire |
|------------|-------------|
| ![Secrétaire](screenshots/secretaire.png) | ![Vétérinaire](screenshots/veterinaire.png) |

## ▶️ Lancer le projet

### Prérequis

- Windows
- Visual Studio avec la charge de travail **Développement .NET Desktop**
- .NET Framework 4.8
- SQL Server LocalDB (installé avec Visual Studio)

### Installation

1. Cloner le dépôt :
   ```bash
   git clone https://github.com/ghada-kaabi/clinique-veterinaire-csharp.git
   ```
   ou télécharger le ZIP depuis le bouton **Code**.
2. Ouvrir le fichier `.sln` avec Visual Studio.
3. Vérifier que le fichier `CliniqueDB.mdf` est présent dans le projet. Il est rattaché automatiquement grâce à la chaîne de connexion :
   ```csharp
   @"Data Source=(LocalDB)\MSSQLLocalDB;
     AttachDbFilename=|DataDirectory|\CliniqueDB.mdf;
     Integrated Security=True"
   ```
4. Compiler et lancer avec **F5**.

Si Visual Studio signale des erreurs du concepteur, supprimer les dossiers `bin` et `obj`, puis régénérer la solution.

### Comptes de démonstration

| Rôle | Email | Mot de passe |
|------|-------|--------------|
| Administrateur | admin@clinique.com | admin123 |
| Secrétaire | secretaire@clinique.com | secret123 |
| Vétérinaire | vet@clinique.com | vet123 |

Les données de la base sont fictives.

## 🧪 Tests réalisés

| Scénario | Résultat |
|----------|----------|
| Connexion avec identifiants corrects (Admin) | Ouverture de l'interface administrateur ✅ |
| Connexion avec identifiants incorrects | Message d'erreur ✅ |
| Ajout et suppression d'un utilisateur | Liste mise à jour ✅ |
| Ajout d'un rendez-vous (secrétaire) | Rendez-vous enregistré ✅ |
| Enregistrement d'une consultation (vétérinaire) | Consultation et facture créées, stock diminué ✅ |
| Filtre des rendez-vous par date | Rendez-vous du jour affichés ✅ |

Tests d'intégrité : impossible de supprimer un propriétaire qui a des animaux (clé étrangère) ; en cas d'erreur, aucune donnée n'est modifiée (rollback).

## 🚀 Améliorations possibles

- Hachage des mots de passe (ils sont actuellement stockés en clair dans la table `Utilisateurs`)
- Export des factures au format PDF
- Notifications par e-mail pour les rappels de vaccination
- Graphiques d'évolution des revenus
- Version web avec ASP.NET Core
- Application mobile pour les vétérinaires en déplacement

## 👩‍💻 Auteure

**Ghada Kaabi** — étudiante en licence Informatique de gestion, ISG Tunis
Ma contribution : [À COMPLÉTER : décris en une phrase ta part du projet]
📧 kghada360@gmail.com
