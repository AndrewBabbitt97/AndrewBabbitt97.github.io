if ('serviceWorker' in navigator) {
    navigator.serviceWorker.register('/sw.js').then(function(reg) {
        console.log('Successfully registered service worker');
    }).catch(function (err) {
        console.log('Error registering service worker');
    })
}
