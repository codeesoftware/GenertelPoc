import { Selector, ClientFunction } from 'testcafe';
import $ from 'jquery';

// A fixture must be created for each group of tests.
fixture(`Index page`)
    // Load the URL your development server runs on.
    .page('http://localhost:56417');



test('sandor', async t => {
    const inputSelector = await Selector('#testSandor');
    debugger;
    await t
        .expect(inputSelector.value).eql('sandor',"sandor nem létezik");
});

test('firstPage_fullNameValidation_true', async t => {
    const fullNameInput = await Selector('#fullName');
    await t
        .expect(fullNameInput.value).eql('Sandor Imre', "Sandor Imre nem létezik");
    await t
        .click(fullNameInput)
        .pressKey('ctrl+a delete');
    await t
        .typeText(fullNameInput, 'Janos')    
    await t
        .expect(fullNameInput.value).eql('Janos', "Janos nem létezik");
    
    const fullNameErrors = await fullNameInput.sibling('ul').child();    
    await t
        .expect(fullNameErrors.count).eql(1, "Kérjük, adja meg  a teljes nevet! nem létezik");
    
    await t
        .click(fullNameInput)
        .pressKey('ctrl+a delete');
    
    await t
        .expect(fullNameErrors.count).eql(2, "Kérem, ezt a mezőt feltétlenül töltse ki! nem létezik");
});


test('firstPage_ageValidation_true', async t => {
    const ageInput = await Selector('#age');
    await t
        .expect(ageInput.value).eql('27', "Kor nem 27");

    await t
        .click(ageInput)
        .pressKey('ctrl+a delete');
    await t
        .typeText(ageInput, '10')
    await t
        .expect(ageInput.value).eql('10', "Kor nem 10");
    
    const ageErrors = await ageInput.sibling('ul').child();    
    await t
        .click(ageInput)
        .pressKey('ctrl+a delete');

    await t
        .expect(ageErrors.count).eql(1, "Nem megfelelő korcsoport! nem létezik");
});


test('firstPage_secondPageNavigation_true', async t => {
    const nextPageButton = await Selector('#nextPageButton');
    await t
        .click(nextPageButton);
    const getLocation = ClientFunction(() => document.location.href);

    await t
        .expect(getLocation()).contains('/home/2');
    
});

test('secondPage_endButtonDisabled_true', async t => {
    const endPageButton = await Selector('#endPageButton');
    await t.expect(endPageButton.exists).ok();
  //  await t.expect($('#endPageButton').disabled).ok();

});