using System;
using PointOfSale.Model;
using PointOfSale.Test.Data;
using PointOfSale.Validators;
using Xunit;

namespace PointOfSale.Test
{
    public class PriceDataValidatorTests
    {
        [Fact]
        public void PriceDataValidatorWithValidData()
        {
            //  Prepare
            var priceDataValidator = new PriceDataValidator();
            var priceData = new PriceData(new PriceDataValues());

            // Act
            priceDataValidator.Validate(priceData);

            // Assert
            Assert.True(true);


        }

        [Fact]
        public void PriceDataValidatorWithInvalidData()
        {
            //  Prepare
            var priceDataValidator = new PriceDataValidator();
            var priceData = new PriceData(new InvalidPriceDataValues());

            // Act
            var thrown = Assert.Throws<ArgumentException>(() => priceDataValidator.Validate(priceData));

            // Assert
            Assert.Equal("priceData", thrown.ParamName);

        }

    }
}
