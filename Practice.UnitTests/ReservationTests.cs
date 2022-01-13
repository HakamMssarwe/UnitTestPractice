using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice.Models;

namespace Practice.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {

            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert
            Assert.AreEqual(result,true);

        }


        [TestMethod]
        public void CanBeCancelledBy_IsMadeByUser_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();
            var user = new User();
            reservation.MadeBy = user;

            //Act
            var result = reservation.CanBeCancelledBy(user);


            //Assert
            Assert.AreEqual(result,true);

        }


        [TestMethod]
        public void CanBeCancelledBy_UserIsNotAdmin_ReturnsFalse()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User());

            //Assert
            Assert.AreEqual(result,false);
        }

    }
}
