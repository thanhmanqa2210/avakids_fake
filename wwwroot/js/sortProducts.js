$(document).ready(() => {
  $(".click-sort").click(() => {
    if ($(".sort-select-main").css("display") == "block") {
      $(".sort-select-main").css({ display: "none" });
    } else {
      $(".sort-select-main").css({ display: "block" });
    }
  });
  //   console.log($(".sort-select-main")[0].children.length);
  var sortItem = $(".sort-select-main")[0].children;
  $(".sort-select-main p").click(function () {
    if (!$(this).hasClass("active")) {
      $(this).addClass("active");
      //   console.log($(this)[0],"sortitem:",sortItem);
      for (var i = 0; i < sortItem.length; i++) {
        if ($(this)[0] != $(sortItem)[i]) {
          $($(sortItem)[i]).removeClass("active");
        }
      }
    }
  });
});
