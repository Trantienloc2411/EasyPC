# EasyPC - [![CI/CD .NET 10](https://github.com/Trantienloc2411/EasyPC/actions/workflows/BuildTest.yml/badge.svg)](https://github.com/Trantienloc2411/EasyPC/actions/workflows/BuildTest.yml)

EasyPC is an intelligent PC building platform that helps users create compatible computer builds, receive hardware recommendations, estimate costs, and plan future upgrades.

The goal of EasyPC is to simplify the PC building experience for both beginners and enthusiasts by combining component compatibility validation, performance insights, and AI-powered recommendations into a single platform.

---

## Features

### Build Your PC

- Create custom PC builds
- Select components from a hardware catalog
- Track total build cost
- Save and manage multiple builds

### Compatibility Validation

Automatically verify compatibility between:

- CPU and Motherboard
- Motherboard and RAM
- GPU and Case
- PSU and Power Requirements
- Storage Devices and Motherboard
- CPU Cooler and Socket

### AI Recommendations

Generate complete PC builds based on:

- Budget
- Intended Usage
- Gaming Requirements
- Productivity Workloads
- Upgrade Goals

Example:

> Build me a gaming PC under $1000 for 1440p gaming.

### Upgrade Planner

Analyze an existing build and recommend:

- Performance improvements
- Bottleneck reductions
- Cost-effective upgrade paths

### Build Comparison

Compare multiple builds side-by-side based on:

- Price
- Performance
- Power Consumption
- Upgrade Potential

---

## Tech Stack

### Frontend

- Next.js
- TypeScript
- Tailwind CSS
- React Query
- Zustand

### Backend

- .NET 10
- ASP.NET Core Web API
- Entity Framework Core
- Clean Architecture

### Database

- PostgreSQL

### Authentication

- JWT Authentication
- Refresh Token Support

### Infrastructure

- Docker
- Docker Compose
- GitHub Actions

---

## Architecture

EasyPC follows a **Modular Monolith Architecture**.

The application is deployed as a single unit while keeping business domains isolated into independent modules. This approach provides clear boundaries between features while avoiding the complexity of a distributed microservice system.

### Benefits

* Easier deployment and maintenance
* Clear separation of business domains
* Better scalability of the codebase
* Reduced operational complexity
* Easier transition to microservices if needed in the future

### Backend Structure

```text
backend/
│
├── EasyPC.API/
│
├── Modules/
│   │
│   ├── Identity/
│   │   ├── Application/
│   │   ├── Domain/
│   │   ├── Infrastructure/
│   │   └── Contracts/
│   │
│   ├── Catalog/
│   │   ├── Application/
│   │   ├── Domain/
│   │   ├── Infrastructure/
│   │   └── Contracts/
│   │
│   ├── Builds/
│   │   ├── Application/
│   │   ├── Domain/
│   │   ├── Infrastructure/
│   │   └── Contracts/
│   │
│   ├── Compatibility/
│   │   ├── Application/
│   │   ├── Domain/
│   │   ├── Infrastructure/
│   │   └── Contracts/
│   │
│   └── Recommendations/
│       ├── Application/
│       ├── Domain/
│       ├── Infrastructure/
│       └── Contracts/
│
├── Shared/
│   ├── BuildingBlocks/
│   ├── Infrastructure/
│   └── Kernel/
│
└── Tests/
```

### Initial Modules

#### Identity Module

Responsible for:

* Authentication
* Authorization
* User Profiles
* User Preferences

#### Catalog Module

Responsible for:

* Hardware Components
* Brands
* Specifications
* Categories

#### Builds Module

Responsible for:

* PC Builds
* Saved Configurations
* Build Sharing
* Build History

#### Compatibility Module

Responsible for:

* Compatibility Rules
* Validation Engine
* Power Consumption Calculation

#### Recommendations Module

Responsible for:

* AI Build Suggestions
* Budget Optimization
* Upgrade Recommendations
* Future Recommendation Logic

```
```

## Planned Features

### MVP

- User Authentication
- Component Catalog
- PC Build Creation
- Compatibility Checking
- Build Management

### Version 1.0

- AI Build Recommendations
- Upgrade Planner
- Build Comparison
- Export Build Configuration

### Future

- FPS Estimation
- Price Tracking
- Community Builds
- Affiliate Store Integration
- Mobile Application

---

## Getting Started

### Prerequisites

- Node.js 22+
- .NET 10 SDK
- PostgreSQL 17+
- Docker (Optional)

### Clone Repository

```bash
git clone https://github.com/your-org/easypc.git

cd easypc
```

### Frontend

```bash
cd frontend

npm install

npm run dev
```

Frontend will be available at:

```text
http://localhost:3000
```

### Backend

```bash
cd backend/EasyPC.API

dotnet restore

dotnet run
```

Backend will be available at:

```text
https://localhost:5001
```

---

## Project Goals

EasyPC aims to become a platform that helps users:

- Build PCs confidently
- Avoid incompatible hardware purchases
- Optimize performance within a budget
- Discover the best upgrade opportunities
- Make informed purchasing decisions

---

## License

MIT License
