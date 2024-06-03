+---------------------+
|      Address        |
+---------------------+
| -street: string     |
| -city: string       |
| -state: string      |
| -country: string    |
+---------------------+
| +Address(street: string, city: string, state: string, country: string) |
| +IsInUSA(): bool    |
| +ToString(): string |
+---------------------+

    ^
    |
    |
+----------------------+
|      Customer        |
+----------------------+
| -name: string        |
| -address: Address    |
+----------------------+
| +Customer(name: string, address: Address) |
| +IsInUSA(): bool     |
| +GetName(): string   |
| +GetAddress(): string|
+----------------------+

+----------------------+
|       Product        |
+----------------------+
| -name: string        |
| -productId: string   |
| -price: double       |
| -quantity: int       |
+----------------------+
| +Product(name: string, productId: string, price: double, quantity: int) |
| +GetTotalCost(): double |
| +GetName(): string    |
| +GetProductId(): string|
+----------------------+

    ^
    |
    |
+-----------------------+
|        Order          |
+-----------------------+
| -products: List<Product> |
| -customer: Customer    |
+-----------------------+
| +Order(customer: Customer) |
| +AddProduct(product: Product) |
| +CalculateTotalCost(): double |
| +GetPackingLabel(): string   |
| +GetShippingLabel(): string  |
+-----------------------+
