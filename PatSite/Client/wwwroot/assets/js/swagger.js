window.loadSwagger = function () {
    const ui = SwaggerUIBundle({
        url: 'https://patapi20240109204434.azurewebsites.net/swagger/v1/swagger.json',
        dom_id: '#swagger-ui',
        presets: [
            SwaggerUIBundle.presets.apis
        ]
    })
    window.ui = ui
}