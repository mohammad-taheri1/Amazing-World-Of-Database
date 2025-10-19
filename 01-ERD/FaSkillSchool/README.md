# Fa Skill School

## Main idea

- A web-based system for managing technical knowledge and interview questions.
- It allows users to read articles, answer interview-style questions, and track their progress over time.
- The system has users with different roles. Admins can create and manage articles and questions.
- Articles and questions may belong to multiple categories.
- Questions are currently multiple-choice type, but more types will be added in the future.
- Users can create their own interview sessions, where they choose categories and number of questions.
- The system then generates a quiz-like test from those categories, and after completion, stores the results.
- Each session records the user’s selected answers, correct answers, and overall score, which can be reviewed later.
- Timing is not priority for now, but may be added later.

## System Architecture Overview

- This project follows `Domain-Driven Design (DDD)` principles and `Clean Architecture` layering.

- **Main Layers:**
1. Domain Layer: Contains core business logic, entities, and value objects.
2. Application Layer: Contains services, DTOs, use cases, and business rules.
3. Infrastructure Layer: Contains EF Core configurations, repositories, database context, and integrations.
4. API Layer: Provides REST endpoints and handles request/response mapping.

- Database: Microsoft SQL Server.
- ORM: Entity Framework Core (Code-First).
- Caching: Microsoft  IMemoryCache.

## Terminology

- `AppUser`: represents users of the system. Users can have different roles (e.g., Admin, Regular User).
- `AppRole`: defines roles such as Admin or User.
- `Article`: written content created by admins (later by users too). Each article belongs to one Category.
- `Category`: defines topic areas like Frontend, Backend, Database, etc.
- `Question`: a technical question, currently of multiple-choice type, possibly linked to multiple categories.
- `QuestionOption`: represents the answer options for a question, with a flag to mark the correct one.
- `InterviewSession`: a test created by a user, containing a selection of questions.
- `UserAnswer`: stores each user’s answer to a question within a session, including correctness.
- `SessionResult`: summarizes the total score and performance of a completed session.


## Domain Design

-----------------------------------------------------------
- Domain: `Identity`
- Schema: `identity`
- Entities: `AppUser`, `AppRole`, `AppUserRole`
- Responsibility: Manages authentication, authorization, and user roles.
-----------------------------------------------------------
- Domain: `KnowledgeBase`
- Schema: `knowledge`
- Entities: `Article`, `Category`
- Responsibility: Handles articles and content organization.
-----------------------------------------------------------
- Domain: `QuestionBank`
- Schema: `question`
- Entities: `Question`, `QuestionOption`, `QuestionCategory`
- Responsibility: Stores technical questions and options; supports multiple categories per question.
-----------------------------------------------------------
- Domain: `Interview`
- Schema: `interview`
- Entities: `InterviewSession`, `UserAnswer`, `SessionResult`
- Responsibility: Manages interview sessions, user answers, and scoring results.
-----------------------------------------------------------

## Technical Conventions

- Entity: Entity must inherit from BaseEntity. Also, it must be sealed.
- BaseEntity<T>: Common class for all entities with audit fields. It must be abstract.
- PrimaryKey: `long` and `Guid`. Defined per entity in EntityConfiguration `EntityTypeBuilder<Entity>().HasKey((q => q.Id))`.
- Schemas: Defined per entity in EntityConfiguration `EntityTypeBuilder<Entity>().ToTable(TableName, SchemaName)`.
- Relationship Style: Explicit navigation properties with Fluent API configuration.
- Soft Delete: Managed via `Deleted` flag in `BaseEntity`.

## Future Extensions

- Add question types (True/False, descriptive).
- Implement question difficulty levels.
- Add timing control and detailed analytics for sessions.
- Allow users to contribute articles/questions (with admin review).
- Add Redis IDistributedCache in case of growing.
- Flag some  questions as `faq`. These questions must have higher priority in the session generation algorithm.