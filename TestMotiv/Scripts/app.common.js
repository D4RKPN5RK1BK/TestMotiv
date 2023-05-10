/**
 * Установка значений для выбора в Dropdown формах
 * @param id
 * @param url
 */
function setDropDownValue (id, url) {
    ajaxGet(url, (data) => {
        let content = '';
        data.forEach((i) => {
            content += `<option value="${i.Key}">${i.Value}</option>` 
        });
        $(id).innerHTML = content;
    });
}