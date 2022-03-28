CREATE TRIGGER Items_DELETE
ON Items
AFTER DELETE
AS
SELECT 'Запись удалена', IdProduct  FROM deleted;
