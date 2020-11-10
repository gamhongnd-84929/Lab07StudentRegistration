CREATE TABLE [Courses] (
    [CourseId]     INT           IDENTITY (1, 1) NOT NULL,
    [CourseNumber] INT           NOT NULL,
    [DepartmentId] INT           NOT NULL,
    [CourseName]   NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED ([CourseId] ASC),
    CONSTRAINT [FK_Courses_Departments_DepartmentId] FOREIGN KEY ([DepartmentId]) REFERENCES [Departments] ([DepartmentId]) ON DELETE CASCADE
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_CourseNumber_DepartmentId]
    ON [Courses]([CourseNumber] ASC, [DepartmentId] ASC);

