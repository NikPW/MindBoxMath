SELECT Products.Name, Category.Name
FROM Products LEFT JOIN Category ON Products.id = Category.ProductId 