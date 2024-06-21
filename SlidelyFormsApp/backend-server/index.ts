const express = require('express');
const fs = require('fs');

const app = express();
const PORT = 3000;
const dbFilePath = './db.json';

app.use(express.json());

app.get('/ping', (req, res) => {
    res.send(true);
});

app.post('/submit', (req, res) => {
    const { name, email, phone, github_link, stopwatch_time } = req.body;
    const newSubmission = { name, email, phone, github_link, stopwatch_time };

    let db = JSON.parse(fs.readFileSync(dbFilePath, 'utf8'));
    db.submissions.push(newSubmission);
    fs.writeFileSync(dbFilePath, JSON.stringify(db));

    res.send('Submission saved successfully');
});

app.get('/read', (req, res) => {
    const { index } = req.query;
    let db = JSON.parse(fs.readFileSync(dbFilePath, 'utf8'));
    if (index < 0 || index >= db.submissions.length) {
        res.status(404).send('Submission not found');
    } else {
        res.json(db.submissions[index]);
    }
});

app.listen(PORT, () => {
    console.log(`Server is running on http://localhost:${PORT}`);
});

// Initial setup for db.json
if (!fs.existsSync(dbFilePath)) {
    fs.writeFileSync(dbFilePath, JSON.stringify({ submissions: [] }));
}
