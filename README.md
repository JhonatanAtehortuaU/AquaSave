# 💧 AquaSave

**AquaSave** es una aplicación educativa y de gestión que promueve el ahorro del agua mediante retos personalizados para los usuarios.
El sistema permite registrar usuarios, asignar retos diarios, semanales o especiales, y llevar un historial de puntos según su cumplimiento.

---

## 🧩 Descripción del Proyecto

El proyecto **AquaSave** forma parte de una práctica de desarrollo de software con base de datos en **SQL Server** y una interfaz en **C# Windows Forms**.
Se aplican principios de **programación orientada a objetos**, **patrón Factory**, y **repositorio en memoria** para la gestión de datos.

El sistema permite:

* Registro y autenticación de usuarios.
* Creación y asignación de retos con distintos niveles de dificultad.
* Registro de participación y puntos obtenidos.
* Persistencia simulada mediante repositorio y modelo de base de datos SQL Server.

---

## 👥 Integrantes y Roles

| Integrante                             | Rol                                                         |
| -------------------------------------- | ----------------------------------------------------------- |
| **Jhonatan Atehortua**                 | Desarrollador principal / Arquitectura del sistema          |
| **Tomas Gil Gomez**                    | Desarrolador FrontEnd                                       |

---

## ⚙️ Tecnologías Utilizadas

* **Lenguaje:** C# (.NET Framework)
* **Interfaz:** Windows Forms
* **Base de datos:** SQL Server
* **Control de versiones:** Git / GitHub
* **Patrones aplicados:** Factory Pattern, Repository Pattern
* **IDE recomendado:** Visual Studio 2022

---

## 🚀 Instrucciones para Ejecutar el Proyecto

### 1️⃣ Clonar el repositorio

```bash
git clone https://github.com/JhonatanAtehortuaU/AquaSave.git
```

### 2️⃣ Abrir en Visual Studio

* Abrir el archivo `AquaSave.sln`.
* Asegurarse de tener `.NET Framework 4.8` (o compatible).

### 3️⃣ Configurar la base de datos

* Abrir **SQL Server Management Studio (SSMS)**.
* Ejecutar el script SQL del proyecto (ver enlace abajo).
* Verificar que la base de datos **AquaSaveDB** se haya creado correctamente.

### 4️⃣ Ejecutar el programa

* Presionar **F5** o **Iniciar** en Visual Studio.
* Iniciar sesión con el usuario administrador:

  ```
  Correo: admin@aquasave.com
  Contraseña: 1234
  ```

---

## 🗂️ Estructura del Proyecto

```
AquaSave/
│
├── Forms/
│   ├── FrmLogin.cs
│   ├── FrmRegistro.cs
│   └── FormMain.cs
│
├── Models/
│   ├── User.cs
│   ├── Challenge.cs
│   ├── ChallengeDay.cs
│   ├── WeeklyChallenge.cs
│   └── ChallengeSpecial.cs
│
├── Factories/
│   └── ChallengeFactory.cs
│
├── Repositories/
│   └── InMemoryRepository.cs
│
├── AquaSave.sln
└── README.md
```

---

Incluye:

* Creación de base de datos **AquaSaveDB**
* Tablas: `Usuarios`, `Retos`, `Participaciones`, `HistorialPuntos`
* Llaves primarias y foráneas
* Datos semilla (usuarios, retos iniciales, historial)

---

## 🧠 Normalización

El modelo de datos cumple con la **Tercera Forma Normal (3FN)**:

* Cada tabla tiene una **clave primaria**.
* No existen **dependencias transitivas**.
* Los datos redundantes fueron eliminados.

---

## 💬 Ejemplo de Credenciales Iniciales

| Correo                                          | Contraseña | Rol           |
| ----------------------------------------------- | ---------- | ------------- |
| [admin@aquasave.com](mailto:admin@aquasave.com) | 1234       | Administrador |
| [maria@correo.com](mailto:maria@correo.com)     | abcd       | Usuario       |
| [carlos@correo.com](mailto:carlos@correo.com)   | pass123    | Usuario       |

---

## 📌 Notas

* Los retos se crean con niveles de dificultad automáticos según la cantidad de puntos:

  * `<=10` → Fácil
  * `>10 y <=20` → Media
  * `>20` → Difícil
* El patrón **Factory** se usa para generar los objetos `ChallengeDay`, `WeeklyChallenge` y `ChallengeSpecial` según el tipo de reto.

---

## 🧾 Licencia

Este proyecto es de uso académico y educativo.
Desarrollado por el equipo **AquaSave © 2025**.
