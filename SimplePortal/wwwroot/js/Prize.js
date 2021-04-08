var rgPriceStopData = [{ "price": "free", "label": "\u0411\u0435\u0437\u043a\u043e\u0448\u0442\u043e\u0432\u043d\u043e" }, { "price": 40, "label": "\u0414\u043e 40\u20b4" }, { "price": 80, "label": "\u0414\u043e 80\u20b4" }, { "price": 120, "label": "\u0414\u043e 120\u20b4" }, { "price": 160, "label": "\u0414\u043e 160\u20b4" }, { "price": 200, "label": "\u0414\u043e 200\u20b4" }, { "price": 240, "label": "\u0414\u043e 240\u20b4" }, { "price": 280, "label": "\u0414\u043e 280\u20b4" }, { "price": 320, "label": "\u0414\u043e 320\u20b4" }, { "price": 360, "label": "\u0414\u043e 360\u20b4" }, { "price": 400, "label": "\u0414\u043e 400\u20b4" }, { "price": 440, "label": "\u0414\u043e 440\u20b4" }, { "price": 480, "label": "\u0414\u043e 480\u20b4" }, { "price": null, "label": "\u0411\u0443\u0434\u044c-\u044f\u043a\u0430 \u0446\u0456\u043d\u0430" }];
$J(function () {

    $J('#price_range').on('input', function () {
        $J('#price_range_display').text(rgPriceStopData[this.value].label);
    }).trigger('input');

    $J('#price_range').on('change', function () {
        $J('#maxprice_input').val(rgPriceStopData[this.value].price);
        AjaxSearchResults();
    });
})

function UpdatePriceRangeControl(maxprice) {
    var $Input = $J('#price_range');
    if (!maxprice)
        $Input.val(13);
    else {
        for (var i = 0; i < rgPriceStopData.length; i++) {
            if (rgPriceStopData[i].price == maxprice) {
                $Input.val(i);
                break;
            }
        }
    }
    $Input.trigger('input');
}