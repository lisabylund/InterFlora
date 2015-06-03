$(".get-orders").click(function () {
    alert("Börjar hämta ordrar");
    SendOrder();
});

function SendOrder() {
    jQuery.support.cors = true;
    var order = { orderId: "556d6b6c0c353f7bf08ded99", price: 20, orderName: "Rosella Good", orderEmail: "rosellagood@oatfarm.com", deliveryAddress: "152 Madoc Avenue, Nogal, Wisconsin, 3802" };
    $.ajax({
        url: 'http://localhost:61173/api/order',
        type: 'POST',
        contentType: "application/json",
        data: JSON.stringify(order),
        success: function (response) {
            alert("Success");
            ShowJsonOrder(response);
        },
        error: function (x, y, z) {
            alert(x + '\n' + y + '\n' + z);
        }
    });
}

function SendCustomer() {
    jQuery.support.cors = true;
    var order = { orderId: "556d6b6c0c353f7bf08ded99", price: 20, orderName: "Rosella Good", orderEmail: "rosellagood@oatfarm.com", deliveryAddress: "152 Madoc Avenue, Nogal, Wisconsin, 3802" };
    $.ajax({
        url: 'http://localhost:61173/api/order',
        type: 'POST',
        contentType: "application/json",
        data: JSON.stringify(order),
        success: function (response) {
            alert("Success");
            ShowJsonOrder(response);
        },
        error: function (x, y, z) {
            alert(x + '\n' + y + '\n' + z);
        }
    });
}


function ShowJsonOrder(json) {

    var transform = [

    {
        tag: 'ul', class: 'order', children: [
           { tag: 'li', html: 'Namn: ${OrderName}' },
           { tag: 'li', html: 'OrderID: ${OrderId}' },
           { tag: 'li', html: 'Email: ${OrderEmail}' },
           { tag: 'li', html: 'Leverandadress: ${DeliveryAddress}' },
           { tag: 'li', html: 'OrderID: ${OrderId}' },
           { tag: 'li', html: 'Pris: ${Price}' },
           { tag: 'li', html: 'Tid skickad: ${TimeSent}' }
        ]
    }

    ];


    $('#json').json2html(json, transform);
}