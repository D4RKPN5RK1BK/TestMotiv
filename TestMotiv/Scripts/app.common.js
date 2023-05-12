/**
 * Установка значений для выбора в Dropdown формах
 * @param selector
 * @param url
 * @param value
 */
function setDropDownValue (selector, url, value) {
    ajaxGet(url, (data) => {
        const content = data.map((i) => `<option '${i.Key == value ? "selected" : ''} value="${i.Key}">${i.Value}</option>`);
        console.log("selector", selector);
        console.log("url", url);
        console.log("value", value);
        console.log("content", content);
        $(selector).first().html(content);
    });
}

function setClickHandler(selector, handler) {
    $(document).on("click", selector, function() {
        handler(this);
    });
}