# Lab5-

create proc USP_GetProducts
as
BEGIN
select * from Product;
END



CREATE PROCEDURE InsertProduct 
    @IdProducto VARCHAR(20),
    @Nombre VARCHAR(20),
    @Codigo VARCHAR(20)
AS
BEGIN
    INSERT INTO Product(IdProducto,Nombre,Codigo)
    VALUES (@IdProducto, @Nombre, @Codigo)
END
GO
