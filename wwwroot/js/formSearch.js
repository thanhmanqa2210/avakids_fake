$("#formSearch>input").focus(function () {
  $("#formSearch").css({
    "border-bottom-left-radius": "0px",
    "border-bottom-right-radius": "0px",
  });
  $("body").css({ position: "fixed", width: "100vw" });
});

$("#formSearch>input").blur(function () {
  $("#formSearch").css({
    "border-bottom-left-radius": "20px",
    "border-bottom-right-radius": "20px",
  });
  $("body").css({ position: "relative", width: "100vw" });
});

$(document).ready(function () {
  $("#input_search").keyup(function () {
    if ($("#input_search").val().length >= 2) {
      $.ajax({
        url: "/layout/data",
        type: "GET",
        data: { searchString: $("#input_search").val() },
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        // cache: false,
        success: function (data) {
          var html = "";
          $.each(data, (key, item) => {
            html += `
                    <li class="suggestions_item">
                        <a href="#" class="suggestions_item_div">
                            <div class="suggestions_item_img">
                                <img src="${item.imgs[0]}" alt="" />
                            </div>
                            <div class="content_suggestions">
                                <h3 class="title_content_suggestions">${item.title}</h3>
                                <div class="price_content_suggestions">
                                    <div class="price_new_contentSG">${item._priceNew}₫</div>
                                    <div class="price_old_contentSG">${item._priceOld}₫</div>
                                    <div class="price_percent_contentSG">${item.price_percent}%</div>
                                </div>
                            </div>
                        </a>
                    </li>
                    `;
          });
          $(".suggestions>.suggestions_list").html(html);
        },
        error: function (errormessage) {
          alert(errormessage.responseText);
        },
      });
    } else {
      $.ajax({
        url: "/layout/data",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        // cache: false,
        success: () => {
          var html = "";
          $(".suggestions>ul").html(html);
        },
        error: function (errormessage) {
          alert(errormessage.responseText);
        },
      });
    }
  });
});

// function extraction(value) {}
