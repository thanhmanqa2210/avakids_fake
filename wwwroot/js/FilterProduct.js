$(document).ready(function () {
  var ArrayValues = {
    ArrayValue: [],
    ArrayAmount: 0,
    NFilter: [],
    SortProduct: "default feature",
  };

  var FilterItem = {
    FilterValue: "",
    ArrayValueAmount: 0,
    NameFilter: "",
    Order: ArrayValues.SortProduct,
    Price: "",
  };

  //// ------------------------------------------------------
  // Đếm số filter được chọn và hủy nếu không có sản phẩm được chọn
  var dem = 0;
  var filterVirtual;
  $(".filter-item").click(function () {
    filterVirtual = $(this);
  });

  // ----------------------------------------------------
  $(".c-btnbox").click(function () {
    // kiểm tra có sản phẩm nào có active không để chọn hoặc hủy filter
    // console.log(filterVirtual);
    var filterVirtualX = filterVirtual[0].children[2].children[0].children;
    if ($($(filterVirtual)[0]).hasClass("switch_display")) {
      for (let index = 0; index < filterVirtualX.length; index++) {
        if ($(filterVirtualX[index]).hasClass("active")) {
          dem++;
        } else {
          console.log(
            "giá trị của 'dem' sẽ là 0 vì có sản phẩm không được active"
          );
        }
      }
    }
    if (dem > 0) {
      if (ArrayValues.NFilter.length == 0) {
        ArrayValues.NFilter.push(filterVirtual.attr("data-name"));
      } else {
        for (let index = 0; index <= ArrayValues.NFilter.length; index++) {
          if (ArrayValues.NFilter[index] == filterVirtual.attr("data-name")) {
            break;
          } else {
            if (ArrayValues.NFilter.length == 1) {
              ArrayValues.NFilter.push(filterVirtual.attr("data-name"));
            }
            if (ArrayValues.NFilter.length > 1) {
              dem = 0;
            }
          }
        }
      }
      dem = 0;
    } else {
      ArrayValues.NFilter = ArrayValues.NFilter.filter(
        (item) => item != filterVirtual.attr("data-name")
      );
    }
    //  ----------------------------------------------
    if ($(this).hasClass("active")) {
      ArrayValues.ArrayValue.push($(this).attr("data-name"));
      ArrayValues.ArrayAmount++;
    } else {
      ArrayValues.ArrayValue = ArrayValues.ArrayValue.filter(
        (item) => item != $(this).attr("data-name")
      );
      ArrayValues.ArrayAmount--;
    }

    FilterItem = {
      FilterValue: ArrayValues.ArrayValue.join(", "),
      ArrayValueAmount: ArrayValues.ArrayAmount,
      Order: ArrayValues.SortProduct,
      NameFilter: ArrayValues.NFilter.join(", "),
      Price: "",
    };
    $.ajax({
      url: "/home/ProductItem/",
      type: "GET",
      contentType: "application/json; charset=UTF-8",
      dataType: "html",
      data: FilterItem,
      success: function (data) {
        var x = (data.match(/data-id/g) || []).length / 2;
        $(".total-reloading").text(x);
      },
      error: function (errormessage) {
        alert("Lỗi khi chèn dữ liệu");
      },
    });
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
  // ---------------------------------

  // sắp xếp sản phẩm theo mức độ yêu cầu của khách hàng
  $(".sort-select-main p").click(function () {
    switch ($(this).text()) {
      case "% Giảm nhiều":
      case "Giá cao đến thấp":
      case "Giá thấp đến cao": {
        ArrayValues.SortProduct = $(this).text();
        FilterItem.Order = $(this).text();
        break;
      }
      default: {
        ArrayValues.SortProduct = "default feature";
        FilterItem.Order = "default feature";
        break;
      }
    }
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
