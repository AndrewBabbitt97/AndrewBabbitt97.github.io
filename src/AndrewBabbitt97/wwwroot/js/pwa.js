if ('serviceWorker' in navigator) {
    navigator.serviceWorker.register('/js/sw.js', { scope: '/' }).then(function(reg) {
        console.log('Successfully registered service worker');
    }).catch(function (err) {
        console.log('Error registering service worker');
    })
}
