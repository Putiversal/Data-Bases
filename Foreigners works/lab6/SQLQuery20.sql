CREATE TRIGGER Items_DELETE
ON Items
AFTER DELETE
AS
SELECT '������ �������', IdProduct  FROM deleted;
