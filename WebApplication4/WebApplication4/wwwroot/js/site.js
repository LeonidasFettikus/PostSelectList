$('#add-item').on('click', function () {
    debugger;
    var value = $('#string-value').val();
    $('#hidden-select').append(new Option(value, value));
    $('#table-item tr:last').after('<tr><td>' + value + '</td></tr>')
});