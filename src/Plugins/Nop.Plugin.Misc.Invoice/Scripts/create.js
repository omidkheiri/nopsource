$(document).ready(function () {
  var data;

  $("#invoiceFrom").submit(function (event) {

    event.preventDefault();

    var $formdata = $(this);
    var serializedData = $formdata.serializeArray();
    var f = {};
    serializedData.forEach(element => {
      f[element.name] = element.value;
    });

    var grid = $('#UnitItems').dxDataGrid('instance');
    var dataItems = grid.getDataSource().items();
    console.log(dataItems);

    f['InvoiceSellIUnits'] = dataItems;
    console.log(f)



    $.ajax({
      url: '/invoice/Create?id=@ViewBag.id',
      type: "POST",
      dataType: 'json',
      contentType: "application/json",
      data: JSON.stringify(f),
      success: function (result) {


      },
      error: function (xhr, resp, text) {
        console.log(xhr, resp, text);
      }
    })
  })
})