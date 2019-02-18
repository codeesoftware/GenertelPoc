import { Selector } from 'testcafe';

// A fixture must be created for each group of tests.
fixture(`Index page`)
    // Load the URL your development server runs on.
    .page('http://localhost:56417');



test('sandor', async testController => {
    const inputSelector = await Selector('#testSandor');
    debugger;
    await testController
        .expect(inputSelector.value).eql('sandor',"sandor nem létezik");
});

test('FirstPage/ fullNameInput', async testController => {
    const fullNameInput = await Selector('#fullName');
    await testController
        .expect(fullNameInput.value).eql('Sandor Imre', "Sandor Imre nem létezik");
    await testController
        .click(fullNameInput)
        .pressKey('ctrl+a delete');
    await testController
        .typeText(fullNameInput, 'Janos')    
    await testController
        .expect(fullNameInput.value).eql('Janos', "Janos nem létezik");
    
    const fullNameErrors = await fullNameInput.sibling('ul').child();    
    await testController
        .expect(fullNameErrors.count).eql(1, "Kérjük, adja meg  a teljes nevet! nem létezik");
    
    await testController
        .click(fullNameInput)
        .pressKey('ctrl+a delete');
    
    await testController
        .expect(fullNameErrors.count).eql(2, "Kérem, ezt a mezőt feltétlenül töltse ki! nem létezik");
});


test('FirstPage/ ageInput', async testController => {
    const ageInput = await Selector('#age');
    await testController
        .expect(ageInput.value).eql('27', "Kor nem 27");

    await testController
        .click(ageInput)
        .pressKey('ctrl+a delete');
    await testController
        .typeText(ageInput, '10')
    await testController
        .expect(ageInput.value).eql('10', "Kor nem 10");
    
    const ageErrors = await ageInput.sibling('ul').child();    
    await testController
        .click(ageInput)
        .pressKey('ctrl+a delete');

    await testController
        .expect(ageErrors.count).eql(1, "Nem megfelelő korcsoport! nem létezik");
});