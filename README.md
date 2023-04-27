

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
AS
BEGIN
    INSERT INTO Product(IdProducto,Nombre,Codigo)
    VALUES (@IdProducto, @Nombre, @Codigo)
END
GO
----------------------------------------------

create proc UdpateProduct2 
	@IdProducto varchar(50),
	@Codigo varchar(50),
	@Nombre varchar(50)
as 

BEGIN
     UPDATE Product
		SET    Nombre = @Nombre,
               Codigo = @Codigo
        WHERE  IdProducto= @IdProducto

END
