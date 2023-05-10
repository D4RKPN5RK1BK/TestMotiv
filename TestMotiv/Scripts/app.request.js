/**
 * Пост запрос на сервер
 * @param url
 * @param body
 * @param onComplete
 */
function ajaxPost(url, body, onComplete) {
    fetch(url, {
        method: 'POST',
        headers: {
            'Content-type': 'application/json'
        },
        body: JSON.stringify(url)
    })
        .then((response) => {
            return response.json()
        })
        .then((data) => {
            onComplete(data);
        });
}

/**
 * Put запрос на сервер
 * @param url
 * @param body
 * @param onComplete
 */
function ajaxPut(url, body, onComplete) {
    fetch(url, {
        method: 'PUT',
        headers: {
            'Content-type': 'application/json'
        },
        body: JSON.stringify(url)
    })
        .then((response) => {
            return response.json()
        })
        .then((data) => {
            onComplete(data);
        });
}

/**
 * Delete запрос на сервер
 * @param url
 * @param onComplete
 */
function ajaxDelete(url, onComplete) {
    fetch(url, {
        method: 'DELETE',
        headers: {
            'Content-type': 'application/json'
        }
    })
        .then((response) => {
            return response.json()
        })
        .then((data) => {
            onComplete(data);
        });
}

/**
 * Асинхронное обращение к серверу через Get метод
 * @param url
 * @param onComplete
 */
function ajaxGet(url, onComplete) {
    fetch(url)
        .then((response) => {
            return response.json();
        })
        .then((data) => {
            onComplete(data);
        })
}

