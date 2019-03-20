-- linijski komentar
/* blok komentar :)
CREATE DATABASE upisi
GO
*/
USE upisi;
CREATE TABLE #privremena(
id INT,
ime NCHAR(50),
prezime VARCHAR(50),
mjesto_stanovanja NCHAR(50)
);
INSERT INTO [dbo].[#privremena] (
[id], [ime], [prezime], [mjesto_stanovanja]) 
VALUES (
1, N'Anja                                              ', 
N'Anjic', 
N'Zagreb                                            '
);
SELECT * FROM #privremena;
