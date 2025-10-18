## Best Tech U
### Train for the future

- This is a small technical college with just one physical location.
- Some normal activities:
    - Enter new `students` into system.
	- Keep a catalog of `courses`
	- create `classes` for each `semester`
	- `Enroll` `students` in `classes`
- Terminology used with BestTechU:
    - A `course` is a catalog with number, name and description. It isn't time-bound.
	- A `class` is an instance of a `course` offered in a specific `semester` with a specific `instructor`.
	- An `enrollment` is a record of a `student` taking a specific `class` in a specific `semester`.
- We need to cover `majors`. A `major` is a collection of `courses` that a `student` must complete to graduate with that major.
- A `major` has name and description and a list of `courses`.
- `Students` may `enroll` in multiple `majors`.

## Possible Entities:

- Student
- Course
- Semester
- Class
- Enrollment
- Major
- StudentAssignedToMajor
- CourseToMajor