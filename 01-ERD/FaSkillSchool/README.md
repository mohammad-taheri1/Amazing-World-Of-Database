## Fa Skill School

### Main idea

- A web-based system for managing technical knowledge and interview questions.
- It allows users to read articles, answer interview-style questions, and track their progress over time.
- The system has users with different roles. Admins can create and manage articles and questions.
- Articles and questions may belong to multiple categories.
- Questions are currently multiple-choice type, but more types will be added in the future.
- Users can create their own interview sessions, where they choose categories and number of questions.
- The system then generates a quiz-like test from those categories, and after completion, stores the results.
- Each session records the user’s selected answers, correct answers, and overall score, which can be reviewed later.
- Timing is not priority for now, but may be added later.

### Terminology and structure

- `AppUser`: represents users of the system. Users can have different roles (e.g., Admin, Regular User).
- `AppRole`: defines roles such as Admin or User.
- `Article`: written content created by admins (later by users too). Each article belongs to one Category.
- `Category`: defines topic areas like Frontend, Backend, Database, etc.
- `Question`: a technical question, currently of multiple-choice type, possibly linked to multiple categories.
- `QuestionOption`: represents the answer options for a question, with a flag to mark the correct one.
- `InterviewSession`: a test created by a user, containing a selection of questions.
- `UserAnswer`: stores each user’s answer to a question within a session, including correctness.
- `SessionResult`: summarizes the total score and performance of a completed session.

### Possible Entities:

- AppUser
- AppRole
- Article
- Category
- Question
- QuestionOption
- QuestionToCategory
- InterviewSession
- UserAnswer
- SessionResult