

create proc USP_GetProducts
as
BEGIN
select * from Product;
END

-------------------------------------------
CREATE PROCEDURE InsertProduct 
    @IdProducto VARCHAR(20),
    @Nombre VARCHAR(20),
    @Codigo VARCHAR(20)
    @Activo varchar(50)
AS
BEGIN
    INSERT INTO Product(IdProducto,Nombre,Codigo,Activo)
    VALUES (@IdProducto, @Nombre, @Codigo, @Activo)
END
GO
----------------------------------------------

alter procedure 
UdpateProduct2
@IdProducto varchar(50), 
@Codigo varchar(50), 
@Nombre varchar(50),
@Activo varchar(50)
as

BEGIN UPDATE Product SET Nombre = @Nombre, Codigo = @Codigo,Activo=@Activo WHERE IdProducto= @IdProducto

END

------------------------------------------------

create proc DeleteProduct 
    @IdProducto varchar(50) 
as 
BEGIN
     UPDATE Product
        SET Activo="False"
        WHERE  IdProducto= @IdProducto

END

--------------------------------------------------

create proc USP_GetProducts2 
as
BEGIN 
select *from Product where Activo = 'True'; 
END
