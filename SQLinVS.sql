select * from project_table

select * from release_table;


select a.projectName from project_table a
INNER JOIN ReleaseProject b on a.sysprojId = b.sysprojId
WHERE b.releaseID = 1


UPDATE release_table
SET releaseDate = '12/15/2019'
Where releaseID = 2;

INSERT INTO release_table
Values ('2/20/2019', 'Code Push');

DELETE From release_table
Where releaseID = 5;