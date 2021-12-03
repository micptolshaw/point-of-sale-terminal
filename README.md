# point-of-sale-terminal

## Design Decisions

1. **Pricing Calculation** - This was the key decision which drove the implementation style of the source code.  The calculation needs to support the provided pricing rules, and to have awareness of its limitations.

2. **Error Handling** - As this is a class library, it is reasonable to keep the error handling as approriately typed exceptions populated with relevent data values to assit the client code for this library to make sensible decisions around code flow and to provide meaningful context to any information added to logs or shown to the user.

3. **ProductCode** - Having the product code as a single character allows for a simple interface, but is a good example of an area where having an abstraction to allow for managing change would improve the code.

4. **Order** - The supplied API did not have any way to identify when the customer changed.  Representing the Customer or Order as part of the API interface to improve usability.

## Decision Log


 - A fully featured pricing engine that could withstand the complexity of a the kinds of product pricing mix often seen on websites or in supermarkets including combination discounts and multiple bulk purchase savings is different from the simple pricing model required for this breif.  The decison is to implement for the pricing model as it currently is. That is to limit the model to to require a single item price and may support one multi purchase price for a single item.  The pricing model needs to be verified that it meets these design constraints, to avoid a situation where the customer is over charged for an item.
- Implement a ProductCode class to abstract the implementation of the product code as a single char away from the majority of the library.  This will limit the changes required when the library is extended to support bar codes for the products.  If we need to support multiple product code types, then we can create a IProductCode interface, and have different implementations for each of the product code types.  
- Each API entry point will wrap internal exceptions and rethrow ensuring that a random exception caught in the client appliation would be aware that this exception occured in the context of the checkout terminal.

