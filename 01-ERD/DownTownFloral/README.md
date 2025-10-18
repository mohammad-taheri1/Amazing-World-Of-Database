## DownTown Floral

- A Flower store needs a database design.
- People can order flowers in person or by phone.
- We need to trace the orders and customers.
- Customers doesn't give their information always. But sometimes they give email.
- Inventory is not priority for now.
- Type of products sold in each order is important.
- There might be some Sales Rep. This must be covered.
- We need Order Price history. Because they can be updated during the time.
- They might have Delivery drivers. This must be covered.
- They need to assign a driver to order. drivers will be chose based on the delivery zones.

## Possible Entities:

- Customer
- Product
- Order
- OrderDetail
- SalesRep
- CustomerToSalesRep
- Driver