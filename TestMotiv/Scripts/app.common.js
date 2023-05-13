/**
 * Установка значений для выбора в Dropdown формах
 * @param selector
 * @param url
 * @param value
 * @param withAll
 */
function setDropDownValue (selector, url, value, withAll = false) {
    ajaxGet(url, (data) => {
        let content = '';
        
        if (withAll)
            content += '<option value="-1">Не указано</option>';
            
        content += data.map((i) => `<option ${i.Key == value ? "selected" : ''} value="${i.Key}">${i.Value}</option>`).join();

        $(document).find(selector).first().html(content);
    });
}

/**
 * Добавление обработчика клика
 * @param selector
 * @param handler
 */
function setClickHandler(selector, handler) {
    $(document).on("click", selector, function() {
        handler(this);
    });
}

/**
 * Обработка нажатий на кнопки удаления
 * @param deleteUrl
 */
function setDeleteButtonsHandler(deleteUrl) {
    const deleteButtonSelector = 'button[data-action="delete"]';
    setClickHandler(deleteButtonSelector, (e) => {
        ajaxPost(`${deleteUrl}/${$(e).val()}`, null, () => {
            location.reload();
        });
    });
}