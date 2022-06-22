$(document).ready(() => {
  var ob = ["Hãng", "Loại"];

  $(".filter_child_item").click(function (e) {
    e.stopPropagation();
    e.preventDefault();
  });
  $("a").click((e) => {
    e.preventDefault();
    e.stopPropagation();
  });
  var _fixed_filter = $(".fixed_filter")[0];
  var filter_it = $(".filter-item")[0];
  $(".fixed_filter").click((e) => {
    $(_fixed_filter).removeClass("switch_display");
    $(filter_it).removeClass("switch_display");
    $.each($(".filter-item"), (index, value) => {
      $(value).addClass("z_index_filter");
      var eChild = $(value)[0].lastElementChild;
      $(eChild).removeClass("switch_display");
    });
  });
  var nameId = "";
  var textFilter = {};
  $(".filter-item").click(function (value) {
    var element = $(value)[0].currentTarget;
    if (!textFilter[`${element.id}`]) {
      textFilter[`${element.id}`] = [];
      console.log(textFilter);
    }
    nameId = element.id;

    for (var i = 0; i < $(element)[0].children.length; i++) {
      var valueClass = $(element)[0].children[i];
      // icon top vs bottom
      if ($(valueClass).hasClass("icon_bf_at")) {
        if ($(valueClass).hasClass("select-bf")) {
          $(valueClass).addClass("select-at");
          $(valueClass).removeClass("select-bf");
        } else {
          $(valueClass).removeClass("select-at");
          $(valueClass).addClass("select-bf");
        }
      }
    }
    var eChild = $(element)[0].lastElementChild;
    $("html,body").animate(
      {
        scrollTop: 410,
      },
      "slow"
    );

    if ($(element).hasClass("switch_display")) {
      $(element).addClass("z_index_filter");
      $(element).removeClass("switch_display");
      $(eChild).removeClass("switch_display");
      $(_fixed_filter).removeClass("switch_display");
    } else {
      $(element).removeClass("z_index_filter");
      $(element).addClass("switch_display");
      $(eChild).addClass("switch_display");
      if (element.id == "filter") {
        $(_fixed_filter).addClass("switch_display");
      } else {
      }
      $.each($(".filter-item"), (index, value) => {
        if (value != element) {
          $(value).addClass("z_index_filter");
          $(value).removeClass("switch_display");
          var eChild = $(value)[0].lastElementChild;
          $(eChild).removeClass("switch_display");
        }
      });
    }
  });
  $(window).scroll(function (event) {
    var pos_body = $("html,body").scrollTop();
    if (pos_body > 420) {
      $(".wrapper-filter").addClass("top_fixed_filter");
    } else {
      $(".wrapper-filter").removeClass("top_fixed_filter");
    }
  });
  $(".click-sort").click(() => {
    if ($(".sort-select-main").css("display") == "block") {
      $(".sort-select-main").css({ display: "none" });
    } else {
      $(".sort-select-main").css({ display: "block" });
    }
  });

  $(".c-btnbox").click(function () {
    if ($(this).hasClass("active")) {
      $(this).removeClass("active");
      textFilter[nameId] = textFilter[nameId].filter(
        (item) => item != $(this).attr("data-name")
      );
      console.log(nameId, textFilter[nameId]);
      for (var i = 0; i < $(".filter-item").length; i++) {
        if ($(".filter-item")[i].id == nameId) {
          var x = $(".filter-item")[i];
          var y = $(x)[0].children;
          for (var j = 0; j < y.length; j++) {
            if ($(y[j]).hasClass("select-txt")) {
              if (textFilter[nameId].toString() == "") {
                console.log($(y[j]).text(ob[i - 1]));
              } else {
                console.log($(y[j]).text(textFilter[nameId]));
              }
            }
          }
        }
      }
    } else {
      $(this).addClass("active");
      textFilter[nameId].push($(this).attr("data-name"));
      console.log(nameId, textFilter[nameId]);
      for (var i = 0; i < $(".filter-item").length; i++) {
        if ($(".filter-item")[i].id == nameId) {
          var x = $(".filter-item")[i];
          var y = $(x)[0].children;
          for (var j = 0; j < y.length; j++) {
            if ($(y[j]).hasClass("select-txt")) {
              console.log($(y[j]).text(textFilter[nameId]));
            }
          }
        }
      }
    }
  });
});
