$(document).ready(function () {
  var ArrayValues = {
    ArrayValue: [],
    ArrayAmount: 0,
    NFilter: [],
  };

  var FilterItem = {
    FilterValue: "",
    ArrayValueAmount: 0,
    NameFilter: "",
    Order: "",
    Price: "",
  };
  var dem = 0;
  $(".filter-item").click(function () {
    if (ArrayValues.NFilter.length == 0) {
      ArrayValues.NFilter.push($(this).attr("data-name"));
    } else {
      for (let index = 0; index <= ArrayValues.NFilter.length; index++) {
        if (ArrayValues.NFilter[index] == $(this).attr("data-name")) {
          break;
        } else {
          if (ArrayValues.NFilter.length == 1) {
            ArrayValues.NFilter.push($(this).attr("data-name"));
          }
          if (ArrayValues.NFilter.length > 1) {
            dem = 1;
          }
        }
      }
    }
  });
  $(".c-btnbox").click(function () {
    if ($(this).hasClass("active")) {
      ArrayValues.ArrayValue.push($(this).attr("data-name"));
      ArrayValues.ArrayAmount++;
      console.log(
        "ArrayValue:",
        ArrayValues.ArrayValue,
        "\n ArrayAmount:",
        ArrayValues.ArrayAmount
      );
    } else {
      ArrayValues.ArrayValue = ArrayValues.ArrayValue.filter(
        (item) => item != $(this).attr("data-name")
      );
      ArrayValues.ArrayAmount--;
    }

    FilterItem = {
      FilterValue: ArrayValues.ArrayValue.join(", "),
      ArrayValueAmount: ArrayValues.ArrayAmount,
      Order: "",
      NameFilter: ArrayValues.NFilter.join(", "),
      Price: "",
    };
  });

  //  khi chưa click chuột
  $.ajax({
    url: "/home/ProductItem/",
    type: "GET",
    contentType: "application/json; charset=UTF-8",
    dataType: "html",
    data: FilterItem,
    success: function (data) {
      $("#model_product").html(data);
    },
    error: function (errormessage) {
      alert("Lỗi khi chèn dữ liệu");
    },
  });
  //  khi đã click chuột
  $(".filter-button>.btn-filter-readmore").click(function (e) {
    e.preventDefault();
    e.stopPropagation();
    $.ajax({
      url: "/home/ProductItem/",
      type: "GET",
      contentType: "application/json; charset=UTF-8",
      dataType: "html",
      data: FilterItem,
      success: function (data) {
        $("#model_product").html(data);
      },
      error: function (errormessage) {
        alert("Lỗi khi chèn dữ liệu");
      },
    });
  });
});
