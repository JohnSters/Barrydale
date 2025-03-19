/**
 * Bootstrap Modal interop functions
 */

/**
 * Shows a Bootstrap modal by its ID
 * @param {string} modalId - The ID of the modal element to show
 */
export function showModal(modalId) {
    try {
        const modalElement = document.getElementById(modalId);
        if (!modalElement) {
            console.error(`Modal with ID ${modalId} not found`);
            return;
        }

        if (typeof bootstrap === 'undefined') {
            console.error('Bootstrap is not defined. Make sure it is loaded before calling this function.');
            return;
        }

        const modal = new bootstrap.Modal(modalElement);
        modal.show();
    } catch (error) {
        console.error('Error showing modal:', error);
    }
}

/**
 * Hides a Bootstrap modal by its ID
 * @param {string} modalId - The ID of the modal element to hide
 */
export function hideModal(modalId) {
    try {
        const modalElement = document.getElementById(modalId);
        if (!modalElement) {
            console.error(`Modal with ID ${modalId} not found`);
            return;
        }

        if (typeof bootstrap === 'undefined') {
            console.error('Bootstrap is not defined. Make sure it is loaded before calling this function.');
            return;
        }

        const modal = bootstrap.Modal.getInstance(modalElement);
        if (modal) {
            modal.hide();
        }
    } catch (error) {
        console.error('Error hiding modal:', error);
    }
}

/**
 * Checks if Bootstrap is loaded
 * @returns {boolean} - True if Bootstrap is loaded, false otherwise
 */
export function isBootstrapLoaded() {
    return typeof bootstrap !== 'undefined';
} 