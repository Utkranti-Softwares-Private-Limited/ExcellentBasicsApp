
function validate(ev) {
    if (!ev) {
        ev = window.event;
    }
    if (!ev.ctrlKey && ev.key.length === 1 && (isNaN(+ev.key) || ev.key === " ")) {
        return ev.preventDefault();
    }
}
$(function () {
    $(".multiselect").chosen({
        search_contains: true
    });
})
//$(document).ready(function () {
//    var prm = Sys.WebForms.PageRequestManager.getInstance();
//    prm.add_initializeRequest(InitializeRequest);
//    //prm.add_endRequest(EndRequest);
//    InitAutoCompl();
//});
//function InitializeRequest(sender, args) {
//}
//function EndRequest(sender, args) {
//    InitAutoCompl();
//}
//$(function () {
//    $(".txtchosen").chosen({
//    });
//});
//var prm = Sys.WebForms.PageRequestManager.getInstance();
//if (prm !== null) {
//    prm.add_endRequest(function (sender, e) {
//        if (sender._postBackSettings.panelsToUpdate !== null) {
//            $(".txtchosen").chosen({
//            });
//        }
//    });
//};
//function InitAutoCompl() {
//    $("#txtadmissionno").autocomplete({
//        source: function (request, response) {
//            $.ajax({
//                url: '<%= ResolveUrl("../Services/Search/StudentMaster.asmx/GetStudentFilterData") %>',
//                async: false,
//                data: "{'stdname': '" + request.term + "'}",
//                dataType: "json",
//                type: "POST",
//                contentType: "application/json; charset=utf-8",
//                success: function (data) {

//                    response($.map(data.d, function (item) {
//                        return {
//                            label: item.split('/')[0] + item.split('/')[1] + item.split('/')[2],
//                            admissionno: item.split('/')[0],
//                            studentname: item.split('/')[1],
//                            fathername: item.split('/')[2],
//                            mobile: item.split('/')[3],
//                            val: item.split('/')[0]
//                        }
//                    }))
//                },
//                error: function (response) {
//                    alert(response.responseText);
//                },
//                failure: function (response) {
//                    alert(response.responseText);
//                }
//            });
//        },
//        select: function (event, i) {
//            $("#txtadmissionno").val(i.item.val);
//            $("#admissionno").val(i.item.val);
//        },
//        minLength: 1
//    }).data("ui-autocomplete")._renderItem = function (ul, item) {
//        return $("<li>")
//            .data("ui-autocomplete-item", item)
//            .append("<a>" + item.label + "<br>" + item.desc + "</a>")
//            .appendTo(ul);
//    };
//};
$(document).ready(function () {
    $('.dtpicker').datepicker({
        showOtherMonths: true,
        selectOtherMonths: true,
        changeMonth: true,
        changeYear: true,
    });
    $(".dtpicker").datepicker("option", "showAnim", "clip");
});
if (prm !== null) {
    prm.add_endRequest(function (sender, e) {
        if (sender._postBackSettings.panelsToUpdate !== null) {
            $('.dtpicker').datepicker({
                showOtherMonths: true,
                selectOtherMonths: true,
                changeMonth: true,
                changeYear: true,
                controlType: 'select',
            });
            $(".dtpicker").datepicker("option", "showAnim", "clip");
            $(".multiselect").chosen({
                search_contains: true
            });
           
        }
    });
};

