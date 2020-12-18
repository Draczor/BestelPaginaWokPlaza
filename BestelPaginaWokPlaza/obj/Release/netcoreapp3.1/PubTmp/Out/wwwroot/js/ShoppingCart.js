function appendShoppingCart(result) {
    const winkelwagen = document.querySelector(".shoppingCart");
    winkelwagen.innerHTML = "";
    if (result != null) {
        result.reverse();

        result.forEach(item => {
            console.log(document.querySelector(".shoppingCart #dish-" + item["id"]));
            if (document.querySelector(".shoppingCart #dish-" + item["id"]) == null) {
                var dishDiv = document.createElement("div");
                dishDiv.className = 'shopping-cart-dish';
                dishDiv.id = "dish-" + item["id"];
                winkelwagen.append(dishDiv);

                var dishAantal = document.createElement("div");
                dishAantal.innerHTML = result.filter(dish => dish["id"] == item["id"]).length + "x";
                dishAantal.className = 'shopping-cart-dish-aantal';
                dishDiv.append(dishAantal);

                var dishName = document.createElement("div");
                dishName.innerHTML = item["name"];
                dishName.className = 'shopping-cart-dish-name';
                dishDiv.append(dishName);

                var dishPrice = document.createElement("div");
                var dishTotalPrice = result.filter(dish => dish["id"] == item["id"]).length * item["price"];
                dishPrice.innerHTML = "&#8364; " + dishTotalPrice.toFixed(2);
                dishPrice.className = 'shopping-cart-dish-price';
                dishDiv.append(dishPrice);

                var dishButton = document.createElement("button");
                dishButton.className = "shopping-cart-dish-button btn btn-sm btn-danger";
                dishButton.addEventListener("click", function (e) {
                    $.post("/ShoppingCart/DeleteFromCart", { id: item["id"] }, function (result) {
                        if (parseInt(dishDiv.querySelector(".shopping-cart-dish-aantal").innerHTML) <= 1) {
                            document.getElementById("dish-" + item["id"]).remove();
                            $.get("/ShoppingCart/CalcTotalPrice", function (result) {
                                document.getElementById("total-price").innerHTML = "&#8364; " + parseFloat(result).toFixed(2);
                            });
                        }
                        else {
                            dishDiv.querySelector(".shopping-cart-dish-aantal").innerHTML = parseInt(dishDiv.querySelector(".shopping-cart-dish-aantal").innerHTML) - 1 + "x";
                            let price = dishDiv.querySelector(".shopping-cart-dish-price").innerHTML.replace("€", "");
                            dishDiv.querySelector(".shopping-cart-dish-price").innerHTML = "&#8364; " + (price - item["price"]).toFixed(2);

                            $.get("/ShoppingCart/CalcTotalPrice", function (result) {
                                document.getElementById("total-price").innerHTML = "&#8364; " + parseFloat(result).toFixed(2);
                            });
                        }
                    });

                })
                dishDiv.append(dishButton);

                var minusIcon = document.createElement("i");
                minusIcon.className = 'fa fa-minus shopping-cart-button-icon';
                dishButton.append(minusIcon);

            }
        });
    }
}