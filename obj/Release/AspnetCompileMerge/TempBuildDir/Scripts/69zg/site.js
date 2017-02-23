var fade = true;
$(function () {
    setInterval(function () {
        if (fade) {
            fade = false;
            $("#bannar1").fadeIn("slow");
            $("#bannar2").fadeOut("slow");
        } else {
            fade = true;
            $("#bannar2").fadeIn("slow");
            $("#bannar1").fadeOut("slow");
        }
    }, 88888);
});
function NaviClick(view)
{

    $("#navCenter table").css("background", "rgba(0, 0, 0, 0)");
    $("#" + view).css("background", "#1e50ae none repeat scroll 0 0");
    $.ajax({
        url: app + "/Company/NaviClick/" + view,
        type: "Post",
        success: function (data) {
            $("#centerTopForms").html(data);
        },
        error: function(XMLHttpRequest, textStatus, errorThrown) {
                console.error(textStatus + "     " + errorThrown);
        }
    });
    return false;
}