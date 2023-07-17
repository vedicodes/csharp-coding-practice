import { Observable } from 'rxjs';

export function promiseObservable() {
    try {
        var samplePromise = new Promise((resolve, reject) => {
            console.log("Promise Created");
            setTimeout(() => {
                console.log("Timeout Finished");
                resolve("Promise Message 1");
            }, 2000);
            console.log("Timeout Set");
        });
        samplePromise.then((message) => {
            console.log(`Promise Resolved: ${message}`);
        }).catch(err => {
            console.table(err);
        });
        var sampleObservale$ = new Observable((subscriber) => {
            console.log("Observable Created");
            setTimeout(() => {
                subscriber.next(`Observable Message 1`);
                setTimeout(() => {
                    subscriber.next(`Observable Message 2`);
                    subscriber.complete();
                }, 2000)
            }, 3000);
            console.log("Observable Set");
        });
        sampleObservale$.subscribe({
            next: (message) => {
                console.log(`Observable Updated: ${message}`);
            },
            error: (err) => {
                console.table(err);
            },
            complete: () => {
                console.log("Observable Completed");
            }
        });
    } catch (error) {
        console.table(error);
    }
}