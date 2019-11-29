module.exports = function (options) {
    var seneca = this;
    //define action sum
    seneca.add({ role: 'math', cmd: 'sum' }, sum);
    // define action product
    seneca.add({ role: 'math', cmd: 'product' }, product);
    //function sum definition 

    function sum(msg, respond) {
        var result = msg.left + msg.right
        respond(null, { answer: result })
    }

    //function product definition
    function product(msg, respond) {
        var result = msg.left * msg.right
        respond(null, { answer: result })
    }

    seneca.add({ role: 'CRUD', cmd: 'create' }, createFunc);
    function createFunc(msg, respond) {

        const article = msg.article;
        article.creator = msg.user;
        article.save((err) => {
            if (err) {
                return res.status(400).send({
                    message: getErrorMessage(err)
                });
            } else {
                msg.res.status(200).json(article);
            }
        });
    }

    seneca.add({ role: 'CRUD', cmd: 'delete' }, deleteFunc);
    function deleteFunc(msg, respond) {

        const article = msg.article;
        article.remove((err) => {
            if (err) {
                return res.status(400).send({
                    message: getErrorMessage(err)
                });
            } else {
                msg.res.status(200).json(article);
            }
        });

    }

    seneca.add({ role: 'CRUD', cmd: 'update' }, updateFunc);
    function updateFunc(msg, respond) {

        const article = msg.article;

        article.code = msg.req.body.code;
        article.name = msg.req.body.name;
        article.section = msg.req.body.section;
        article.semester = msg.req.body.semester;
        article.save((err) => {
            if (err) {
                return res.status(400).send({
                    message: getErrorMessage(err)
                });
            } else {
                msg.res.status(200).json(article);
            }
        });

    }

    seneca.add({ role: 'CRUD', cmd: 'read' }, readFunc);
    function readFunc(msg, respond) {
        msg.res.status(200).json(msg.req.article);
    }

}
