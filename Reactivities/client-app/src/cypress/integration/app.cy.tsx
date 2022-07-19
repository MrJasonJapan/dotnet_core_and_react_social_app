export {};
it('should work', () => {
  cy.visit('/');
  cy.get('a').should('have.text', 'Take me to the Activities!');
});
