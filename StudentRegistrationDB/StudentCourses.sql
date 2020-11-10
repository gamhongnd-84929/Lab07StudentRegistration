CREATE TABLE [dbo].[StudentCourses] (
    [CourseId]  INT NOT NULL,
    [StudentId] INT NOT NULL,
    CONSTRAINT [PK_StudentCourses] PRIMARY KEY CLUSTERED ([CourseId] ASC, [StudentId] ASC),
    CONSTRAINT [FK_StudentCourses_Courses_CourseId] FOREIGN KEY ([CourseId]) REFERENCES [Courses] ([CourseId]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.StudentCourses_dbo.Students_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Students] ([StudentId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_CourseId]
    ON [dbo].[StudentCourses]([CourseId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_StudentId]
    ON [dbo].[StudentCourses]([StudentId] ASC);

